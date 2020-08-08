using Football.Data.Abstract;
using Football.Model.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace Football.Web.Services.Profile
{
    public class ProfileManager
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IUnitOfWork _unitOfWork;

        private ApplicationUser _currentUser;

        public ProfileManager(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IHttpContextAccessor httpContextAccessor,
            IUnitOfWork unitOfWork)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _httpContextAccessor = httpContextAccessor;
            _unitOfWork = unitOfWork;
        }

        public ApplicationUser CurrentUser => _currentUser ?? (_currentUser = _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User).Result);

        public bool IsHasPassword(ApplicationUser user)
        {
            return _userManager.HasPasswordAsync(user).Result;
        }

        public bool IsEmailConfirmed(ApplicationUser user)
        {
            return _userManager.IsEmailConfirmedAsync(user).Result;
        }

        //public async Task<UserLocationsViewModel> GetUserLocationsAsync()
        //{
        //    if (CurrentUser == null)
        //        return new UserLocationsViewModel();

        //    var userOffices = _unitOfWork.Offices.GetAllByUserId(CurrentUser.Id).ToList();

        //    if (userOffices.Count == 0)
        //        return new UserLocationsViewModel();

        //    if (CurrentUser.CurrentLocationId == 0)
        //    {
        //        await SetCurrentLocationAsync(userOffices.FirstOrDefault().Id);
        //    }

        //    var locations = new UserLocationsViewModel
        //    {
        //        CurrentLocation = Mapper.Map<Office, LocationViewModel>(userOffices.FirstOrDefault(w => w.Id == CurrentUser.CurrentLocationId)),
        //        AvailableLocations = Mapper.Map<IEnumerable<Office>, IEnumerable<LocationViewModel>>(userOffices)
        //    };

        //    return locations;
        //}

        //public async Task SetCurrentLocationAsync(int locationId)
        //{
        //    var user = await _userManager.FindByIdAsync(CurrentUser.Id.ToString());
        //    user.CurrentLocationId = locationId;
        //    await _userManager.UpdateAsync(user);
        //}
    }
}

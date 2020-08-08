using AutoMapper;
//using PortsInspections.Model.Entities;
//using PortsInspections.Services.Reports.Models;
//using PortsInspections.Web.Areas.Dashboards.ViewModels;
//using PortsInspections.Web.Areas.Files.ViewModels;
//using PortsInspections.Web.Areas.Operations.ViewModels;
//using PortsInspections.Web.Areas.Settings.ViewModels;
//using PortsInspections.Web.Areas.Surveyors.ViewModels;
//using PortsInspections.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Football.Model.Entities;
using Football.Web.Models;


namespace Football.Web.Mappings
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {

            //        CreateMap<ApplicationUser, UserViewModel>()
            //            .ForMember(vm => vm.Offices,
            //                map => map.MapFrom(x => x.Offices.Select(y => y.OfficeId)))
            //            .ForMember(vm => vm.OfficeNames,
            //                map => map.MapFrom(x => x.Offices.Select(y => y.Office.Name)))
            //            .ForMember(vm => vm.Roles,
            //                map => map.MapFrom(x => x.Roles.Select(y => y.Role.Id)))
            //            .ForMember(vm => vm.RoleNames,
            //                map => map.MapFrom(x => x.Roles.Select(y => y.Role.LocalName)))
            //            .ForMember(vm => vm.Language,
            //                map => map.MapFrom(x => x.LanguageId));

            //        CreateMap<Commodity, CommodityViewModel>()
            //            .ForMember(vm => vm.JointName,
            //                map => map.MapFrom(x => $"{x.Name} ({x.LocalName})"));

            //        CreateMap<Country, CountryViewModel>();

            //        CreateMap<Player, PlayerViewModel>()
            //            .ForMember(vm => vm.Street,
            //                map => map.MapFrom(x => x.Address.Street))
            //            .ForMember(vm => vm.Number,
            //                map => map.MapFrom(x => x.Address.Number))
            //            .ForMember(vm => vm.City,
            //                map => map.MapFrom(x => x.Address.City))
            //            .ForMember(vm => vm.State,
            //                map => map.MapFrom(x => x.Address.State))
            //            .ForMember(vm => vm.CountryId,
            //                map => map.MapFrom(x => x.Address.CountryId))
            //            .ForMember(vm => vm.Country,
            //                map => map.MapFrom(x => x.Address.Country.LocalName))
            //            .ForMember(vm => vm.ZipCode,
            //                map => map.MapFrom(x => x.Address.ZipCode))
            //            .ForMember(vm => vm.InvoiceRemarks,
            //                map => map.MapFrom(x => x.InvoiceInformation.Remarks))
            //            .ForMember(vm => vm.Contacts,
            //                map => map.MapFrom(x => x.Contacts))
            //            .ForMember(vm => vm.Types,
            //                map => map.MapFrom(x => GetTypes(x.Types.Select(y => y.PlayerType))));

            //        CreateMap<PlayerContact, PlayerContactViewModel>();

            //        CreateMap<File, FileViewModel>()
            //            .ForMember(vm => vm.Remarks,
            //                map => map.MapFrom(x => x.Remarks.Remarks))
            //            .ForMember(vm => vm.Officers,
            //                map => map.MapFrom(x => x.Officers.Select(y => y.ApplicationUserId)))
            //            .ForMember(vm => vm.Subscribers,
            //                map => map.MapFrom(x => x.Subscribers.Select(y => y.ApplicationUserId)));

            //        CreateMap<File, FileListViewModel>()
            //            .ForMember(vm => vm.Transport,
            //                map => map.MapFrom(x => x.Transport.Name))
            //            .ForMember(vm => vm.FileDescription,
            //                map => map.MapFrom(x => $"{x.Transport.Name} ({x.Id})"))
            //            .ForMember(vm => vm.Officers,
            //                map => map.MapFrom(x => string.Join(", ", x.Officers.Select(y => y.ApplicationUser.UserName))))
            //            .ForMember(vm => vm.Remarks,
            //                map => map.MapFrom(x => x.Remarks.Remarks));

            //        CreateMap<File, FileDetailsViewModel>()
            //            .ForMember(vm => vm.FileColor,
            //                map => map.MapFrom(x => x.Color))
            //            .ForMember(vm => vm.Transport,
            //                map => map.MapFrom(x => x.Transport.Name))
            //            .ForMember(vm => vm.Remarks,
            //                map => map.MapFrom(x => x.Remarks.Remarks))
            //            .ForMember(vm => vm.CreatedBy,
            //                map => map.MapFrom(x => x.Creator.UserName))
            //            .ForMember(vm => vm.Officers,
            //                map => map.MapFrom(x => string.Join(", ", x.Officers.Select(y => y.ApplicationUser.UserName))))
            //            .ForMember(vm => vm.Subscribers,
            //                map => map.MapFrom(x => x.Subscribers.Select(y => y.ApplicationUserId)))
            //            .ForMember(vm => vm.ServiceOrders,
            //                map => map.MapFrom(x => x.ServiceOrders))
            //            .ForMember(vm => vm.Operations,
            //                map => map.MapFrom(x => x.ServiceOrders.Select(y => y.Operation)));

            //        CreateMap<Fact, FactViewModel>();

            //        CreateMap<Office, LocationViewModel>()
            //            .ForMember(vm => vm.Id,
            //                map => map.MapFrom(x => x.Id))
            //            .ForMember(vm => vm.Name,
            //                map => map.MapFrom(x => x.Name));

            //        CreateMap<Office, OfficeViewModel>()
            //            .ForMember(vm => vm.Street,
            //                map => map.MapFrom(x => x.Address.Street))
            //            .ForMember(vm => vm.Number,
            //                map => map.MapFrom(x => x.Address.Number))
            //            .ForMember(vm => vm.City,
            //                map => map.MapFrom(x => x.Address.City))
            //            .ForMember(vm => vm.State,
            //                map => map.MapFrom(x => x.Address.State))
            //            .ForMember(vm => vm.ZipCode,
            //                map => map.MapFrom(x => x.Address.ZipCode))
            //            .ForMember(vm => vm.Country,
            //                map => map.MapFrom(x => x.Country.LocalName))
            //            .ForMember(vm => vm.Users,
            //                map => map.MapFrom(x => x.Users.Select(y => y.User)));

            //        CreateMap<Office, OfficeListViewModel>()
            //            .ForMember(vm => vm.Country,
            //                map => map.MapFrom(x => x.Country.LocalName));

            //        CreateMap<OperationAttachment, AttachmentViewModel>()
            //            .ForMember(vm => vm.Description,
            //                map => map.MapFrom(x => x.Description))
            //            .ForMember(vm => vm.FileName,
            //                map => map.MapFrom(x => x.FileName));

            //        CreateMap<Operation, OperationListViewModel>()
            //            .ForMember(vm => vm.File,
            //                map => map.MapFrom(x => x.File.Id))
            //            .ForMember(vm => vm.Transport,
            //                map => map.MapFrom(x => x.File.Transport.Name))
            //            .ForMember(vm => vm.Port,
            //                map => map.MapFrom(x => x.Port.Name))
            //            .ForMember(vm => vm.ServiceOrders,
            //                map => map.MapFrom(x => x.ServiceOrders.Count()))
            //            .ForMember(vm => vm.ExpectedTons,
            //                map => map.MapFrom(x => x.ServiceOrders.Sum(y => y.ExpectedTons).ToString("#,##0.000")));

            //        CreateMap<Operation, OperationDetailsViewModel>()
            //            .ForMember(vm => vm.File,
            //                map => map.MapFrom(x => x.File.Id))
            //            .ForMember(vm => vm.Reference,
            //                map => map.MapFrom(x =>
            //                    $"{(DateTime)x.File.CreationDate:yyyy}/{x.Port.InternalCode}.{(x.ServiceOrders.FirstOrDefault().Type.Equals(OperationType.Discharge) ? "1" : x.ServiceOrders.FirstOrDefault().Type.Equals(OperationType.Load) ? "7" : "3")}.{x.FileId:D3}"))
            //            .ForMember(vm => vm.TransportId,
            //                map => map.MapFrom(x => x.File.TransportId))
            //            .ForMember(vm => vm.Transport,
            //                map => map.MapFrom(x => x.File.Transport.Name))
            //            .ForMember(vm => vm.Port,
            //                map => map.MapFrom(x => $"{x.Port.Name}, {x.Port.Country.LocalName}"))
            //            .ForMember(vm => vm.PortLatitude,
            //                map => map.MapFrom(x => x.Port.Address.CoordinateLatitude))
            //            .ForMember(vm => vm.PortLongitude,
            //                map => map.MapFrom(x => x.Port.Address.CoordinateLongitude))
            //            .ForMember(vm => vm.Agency,
            //                map => map.MapFrom(x => x.Agency.Name))
            //            .ForMember(vm => vm.Stevedore,
            //                map => map.MapFrom(x => x.Stevedore.Name))
            //            .ForMember(vm => vm.TimeLogEntries,
            //                map => map.MapFrom(x => x.TimeLogEntries))
            //            .ForMember(vm => vm.Reports,
            //                map => map.MapFrom(x => x.Reports))
            //            .ForMember(vm => vm.StowagePlanForDry,
            //                map => map.MapFrom(x => x.StowagePlanForDry))
            //            .ForMember(vm => vm.Attachments,
            //                map => map.MapFrom(x => x.Attachments))
            //            .ForMember(vm => vm.Subscribers,
            //                map => map.MapFrom(x => x.Subscribers.Select(y => y.ApplicationUserId)));

            //        CreateMap<Operation, OperationHeaderViewModel>()
            //            .ForMember(vm => vm.TransportId,
            //                map => map.MapFrom(x => x.File.TransportId))
            //            .ForMember(vm => vm.Transport,
            //                map => map.MapFrom(x => x.File.Transport.Name))
            //            .ForMember(vm => vm.Port,
            //                map => map.MapFrom(x => $"{x.Port.Name}, {x.Port.Country.LocalName}"))
            //            .ForMember(vm => vm.ServiceOrders,
            //                map => map.MapFrom(x => x.ServiceOrders));

            //        CreateMap<Operation, OperationLineUpViewModel>()
            //            .ForMember(vm => vm.Transport,
            //                map => map.MapFrom(x => x.File.Transport.Name))
            //            .ForMember(vm => vm.FileColor,
            //                map => map.MapFrom(x => x.File.Color))
            //            .ForMember(vm => vm.Port,
            //                map => map.MapFrom(x => x.Port.Name))
            //            .ForMember(vm => vm.Office,
            //                map => map.MapFrom(x => x.Port.Office.Name))
            //            .ForMember(vm => vm.Client,
            //                map => map.MapFrom(x => string.Join(", ", x.ServiceOrders.SelectMany(y => y.Figures).Where(f => f.IsPrincipal).Select(p => p.Figure.Name))))
            //            .ForMember(vm => vm.Type,
            //                map => map.MapFrom(x => x.ServiceOrders.First().Type))
            //            .ForMember(vm => vm.ExpectedTons,
            //                map => map.MapFrom(x => x.ServiceOrders.Sum(y => y.ExpectedTons).ToString("#,##0.000")));

            //        CreateMap<OperationSurveyor, OperationSurveyorViewModel>()
            //            .ForMember(vm => vm.Shift,
            //                map => map.Ignore())
            //            .ForMember(vm => vm.Surveyors,
            //                map => map.Ignore());

            //        CreateMap<OperationSurveyor, SurveyorShiftViewModel>()
            //            .ForMember(vm => vm.Shift,
            //                map => map.MapFrom(x => $"{x.ShiftFrom:dd/MM/yyyy HH:mm} - {x.ShiftTo:dd/MM/yyyy HH:mm}"))
            //            .ForMember(vm => vm.Operation,
            //                map => map.MapFrom(x => x.Operation));

            //        CreateMap<OperationTimeLogAttachment, AttachmentViewModel>()
            //            .ForMember(vm => vm.Description,
            //                map => map.MapFrom(x => x.Description))
            //            .ForMember(vm => vm.FileName,
            //                map => map.MapFrom(x => x.FileName))
            //            .ForMember(vm => vm.AttachmentType,
            //                map => map.MapFrom(x => x.AttachmentType));

            //        CreateMap<OperationTimeLog, LogEventViewModel>()
            //            .ForMember(vm => vm.DateRange,
            //                map => map.MapFrom(x => $"{x.DateFrom:dd/MM/yyyy HH:mm} - {x.DateTo:dd/MM/yyyy HH:mm}"))
            //            .ForMember(vm => vm.SortingDate,
            //                map => map.MapFrom(x => x.DateFrom))
            //            .ForMember(vm => vm.SortingDate2,
            //                map => map.MapFrom(x => x.DateTo))
            //            .ForMember(vm => vm.DateFrom,
            //                map => map.MapFrom(x => x.DateFrom.ToString("dd/MM/yyyy HH:mm")))
            //            .ForMember(vm => vm.DateTo,
            //                map => map.MapFrom(x => x.DateTo.ToString("dd/MM/yyyy HH:mm")))
            //            .ForMember(vm => vm.ForOperation,
            //                map => map.MapFrom(x => x.Fact.ForOperation))
            //            .ForMember(vm => vm.FactDescription,
            //                map => map.MapFrom(x => x.Fact.LocalDescription))
            //            .ForMember(vm => vm.FactDisplay,
            //                map => map.MapFrom(x => x.Fact.Display))
            //            .ForMember(vm => vm.FactTriggers,
            //                map => map.MapFrom(x => x.Fact.Triggers))
            //            .ForMember(vm => vm.Remarks,
            //                map => map.MapFrom(x => x.Remarks.Remarks))
            //            .ForMember(vm => vm.ServiceOrder,
            //                map => map.MapFrom(x => x.ServiceOrder))
            //            .ForMember(vm => vm.StorageUnitIds,
            //                map => map.MapFrom(x => x.StorageUnits.Select(y => y.TransportStorageUnitId).ToList()))
            //            .ForMember(vm => vm.StorageUnitId,
            //                map => map.MapFrom(x => x.StorageUnits.Select(y => y.TransportStorageUnitId).ToList().FirstOrDefault()))
            //            .ForMember(vm => vm.StorageUnits,
            //                map => map.MapFrom(x => x.StorageUnits))
            //            .ForMember(vm => vm.ScaleIds,
            //                map => map.MapFrom(x => x.Scales.Select(y => y.PortScaleId).ToList()))
            //            .ForMember(vm => vm.Scales,
            //                map => map.MapFrom(x => string.Join(", ", x.Scales.OrderBy(y => y.PortScale.Name).Select(y => y.PortScale.Name))))
            //            .ForMember(vm => vm.OperationMeansInformation,
            //                map => map.MapFrom(x => x.Quantity))
            //            .ForMember(vm => vm.ConditionForDryProducts,
            //                map => map.MapFrom(x => x.ConditionForDry))
            //            .ForMember(vm => vm.Quantity,
            //                map => map.MapFrom(x => x.Quantity.Quantity))
            //            .ForMember(vm => vm.AttachmentsTimeLog,
            //                map => map.MapFrom(x => x.Attachments))
            //            .ForMember(vm => vm.ReportAt,
            //                map => map.MapFrom(x => x.Fact.ReportAt))
            //                .ForMember(vm => vm.DischargeDistributions,
            //                map => map.MapFrom(x => x.Quantity.Distributions));

            //        CreateMap<OperationTimeLogQuantityDistribution, DischargeDistributionViewModel>()
            //            .ForMember(d => d.PortStorageUnitId,
            //                map => map.MapFrom(x => x.PortStorageUnitId))
            //            .ForMember(d => d.PortStorageUnitDescription,
            //                map => map.MapFrom(x => x.PortStorageUnit.Name))
            //            .ForMember(d => d.DistributionType,
            //                map => map.MapFrom(x => x.DistributionType));

            //        CreateMap<OperationTimeLog, OperationReportTimeLogEntryModel>()
            //            .ForMember(vm => vm.SortingDate,
            //                map => map.MapFrom(x => x.DateFrom))
            //            .ForMember(vm => vm.SortingDate2,
            //                map => map.MapFrom(x => x.DateTo))
            //            .ForMember(vm => vm.DateFrom,
            //                map => map.MapFrom(x => x.DateFrom.ToString("dd.MM.yyyy 'at' HH.mm")))
            //            .ForMember(vm => vm.DateTo,
            //                map => map.MapFrom(x => x.DateTo.ToString("dd.MM.yyyy 'at' HH.mm")))
            //            .ForMember(vm => vm.DateRange,
            //                map => map.MapFrom(x => $"{x.DateFrom:dd.MM.yyyy 'from' HH.mm} to {x.DateTo:HH.mm}"))
            //            .ForMember(vm => vm.ShiftRange,
            //                map => map.MapFrom(x => $"{x.DateFrom:HH.mm} - {x.DateTo:HH.mm}"))
            //            .ForMember(vm => vm.FactDescription,
            //                map => map.MapFrom(x => x.Fact.Description))
            //            .ForMember(vm => vm.Quantity,
            //                map => map.MapFrom(x => x.Quantity.Quantity))
            //            .ForMember(vm => vm.StorageUnits,
            //                map => map.MapFrom(x => string.Join(",", x.StorageUnits.Select(y => y.TransportStorageUnit.Name))))
            //            .ForMember(vm => vm.ReportAt,
            //                map => map.MapFrom(x => x.Fact.ReportAt))
            //            .ForMember(vm => vm.Triggers,
            //                map => map.MapFrom(x => x.Fact.Triggers))
            //            .ForMember(vm => vm.Remarks,
            //                map => map.MapFrom(x => x.Remarks.Remarks))
            //            .ForMember(vm => vm.AmbientTemperature,
            //                map => map.MapFrom(x => x.ConditionForDry.AmbientTemperature))
            //            .ForMember(vm => vm.ProductTemperature,
            //                map => map.MapFrom(x => x.ConditionForDry.ProductTemperature))
            //            .ForMember(vm => vm.Color,
            //                map => map.MapFrom(x => x.ConditionForDry.Color))
            //            .ForMember(vm => vm.ColorDescription,
            //                map => map.MapFrom(x => x.ConditionForDry.ColorDescription))
            //            .ForMember(vm => vm.Smell,
            //                map => map.MapFrom(x => x.ConditionForDry.Smell))
            //            .ForMember(vm => vm.SmellDescription,
            //                map => map.MapFrom(x => x.ConditionForDry.SmellDescription))
            //            .ForMember(vm => vm.Insects,
            //                map => map.MapFrom(x => x.ConditionForDry.Insects))
            //            .ForMember(vm => vm.InsectsDescription,
            //                map => map.MapFrom(x => x.ConditionForDry.InsectsDescription))
            //            .ForMember(vm => vm.Pellets,
            //                map => map.MapFrom(x => x.ConditionForDry.Pellets ?? 0))
            //            .ForMember(vm => vm.HoldStatusAtOpening,
            //                map => map.MapFrom(x => x.ConditionForDry.HoldStatusAtOpening))
            //            .ForMember(vm => vm.HoldStatusAtClosure,
            //                map => map.MapFrom(x => x.ConditionForDry.HoldStatusAtClosure))
            //            .ForMember(vm => vm.ConveyorBelt,
            //                map => map.MapFrom(x => x.Quantity.ConveyorBelt))
            //            .ForMember(vm => vm.Trucks,
            //                map => map.MapFrom(x => x.Quantity.Trucks))
            //            .ForMember(vm => vm.NumberOfScales,
            //                map => map.MapFrom(x => x.Scales.Count()))
            //            .ForMember(vm => vm.Scales,
            //                map => map.MapFrom(x => x.Scales))
            //            .ForMember(vm => vm.Hoppers,
            //                map => map.MapFrom(x => x.Quantity.Hoppers))
            //            .ForMember(vm => vm.Cranes,
            //                map => map.MapFrom(x => x.Quantity.Cranes))
            //            .ForMember(vm => vm.Distributions,
            //                map => map.MapFrom(x => x.Quantity.Distributions));

            //        CreateMap<OperationTimeLogScale, OperationReportScaleViewModel>()
            //            .ForMember(vm => vm.Name,
            //                map => map.MapFrom(x => x.PortScale.Name))
            //            .ForMember(vm => vm.CalibrationValidDate,
            //                map => map.MapFrom(x => x.PortScale.Calibrations.OrderByDescending(y => y.ExpirationDate).FirstOrDefault()
            //                    .ExpirationDate.ToString("dd.MM.yyyy ")));

            //        CreateMap<OperationTimeLogQuantityDistribution, OperationReportDistributionViewModel>()
            //            .ForMember(vm => vm.Description,
            //                map => map.MapFrom(x =>
            //                    x.DistributionType.Equals(DistributionType.ToClients) ? "Clients" : x.PortStorageUnit.Name))
            //            .ForMember(vm => vm.Quantity,
            //                map => map.MapFrom(x => x.QuantityDistributed));

            //        CreateMap<OperationTimeLogStorageUnit, TransportStorageUnitViewModel>()
            //            .ForMember(vm => vm.Name,
            //                map => map.MapFrom(x => x.TransportStorageUnit.Name))
            //            .ForMember(vm => vm.Type,
            //                map => map.MapFrom(x => x.TransportStorageUnit.Type));

            //        CreateMap<OperationReport, OperationReportViewModel>()
            //            .ForMember(vm => vm.Description,
            //                map => map.MapFrom(x => x.Description))
            //            .ForMember(vm => vm.FileName,
            //                map => map.MapFrom(x => x.FileName));

            //        CreateMap<OperationSurveyor, SurveyorsReportViewModel>()
            //            .ForMember(vm => vm.OperationType,
            //                map => map.MapFrom(x => x.Operation.ServiceOrders.First().Type))
            //            .ForMember(vm => vm.Port,
            //                map => map.MapFrom(x => x.Operation.Port.Name))
            //            .ForMember(vm => vm.Transport,
            //                map => map.MapFrom(x => x.Operation.File.Transport.Name))
            //            .ForMember(vm => vm.UserName,
            //                map => map.MapFrom(x => x.ApplicationUser.UserName))
            //            .ForMember(vm => vm.DateFrom,
            //                map => map.MapFrom(x => x.ShiftFrom.ToString("dd/MM/yyyy")))
            //            .ForMember(vm => vm.DateTo,
            //                map => map.MapFrom(x => x.ShiftTo.ToString("dd/MM/yyyy")))
            //            .ForMember(vm => vm.ShiftFrom,
            //                map => map.MapFrom(x => x.ShiftFrom.ToString("HH:mm")))
            //            .ForMember(vm => vm.ShiftTo,
            //                map => map.MapFrom(x => x.ShiftTo.ToString("HH:mm")))
            //            .ForMember(vm => vm.Hours,
            //                map => map.MapFrom(x => (x.ShiftTo - x.ShiftFrom).Hours))
            //            .ForMember(vm => vm.Reference,
            //                map => map.MapFrom(x =>
            //                    $"{(DateTime)x.Operation.File.CreationDate:yyyy}/{x.Operation.Port.InternalCode}.{(x.Operation.ServiceOrders.FirstOrDefault().Type.Equals(OperationType.Discharge) ? "1" : x.Operation.ServiceOrders.FirstOrDefault().Type.Equals(OperationType.Load) ? "7" : "3")}.{x.Operation.FileId:D3}"))
            //            .ForMember(vm => vm.Nominators,
            //                map => map.MapFrom(x => string.Join(", ",
            //                    x.Operation.ServiceOrders.Where(o => o.OperationId == x.OperationId).SelectMany(f => f.Figures.Where(y => y.IsPrincipal).Select(z => z.Figure.Name))
            //                        .GroupBy(name => name).Select(g => g.Key))));

            //        CreateMap<Port, PortViewModel>()
            //            .ForMember(vm => vm.Street,
            //                map => map.MapFrom(x => x.Address.Street))
            //            .ForMember(vm => vm.Number,
            //                map => map.MapFrom(x => x.Address.Number))
            //            .ForMember(vm => vm.City,
            //                map => map.MapFrom(x => x.Address.City))
            //            .ForMember(vm => vm.State,
            //                map => map.MapFrom(x => x.Address.State))
            //            .ForMember(vm => vm.ZipCode,
            //                map => map.MapFrom(x => x.Address.ZipCode))
            //            .ForMember(vm => vm.CoordinateLatitude,
            //                map => map.MapFrom(x => x.Address.CoordinateLatitude))
            //            .ForMember(vm => vm.CoordinateLongitude,
            //                map => map.MapFrom(x => x.Address.CoordinateLongitude))
            //            .ForMember(vm => vm.Country,
            //                map => map.MapFrom(x => x.Country.LocalName))
            //            .ForMember(vm => vm.StorageUnits,
            //                map => map.MapFrom(x => x.StorageUnits.OrderBy(s => s.Name)))
            //            .ForMember(vm => vm.Scales,
            //                map => map.MapFrom(x => x.Scales.OrderBy(s => s.Name)))
            //            .ForMember(vm => vm.Office,
            //                map => map.MapFrom(x => x.Office.Name));

            //        CreateMap<PortStorageUnit, PortStorageUnitViewModel>();

            //        CreateMap<PortScale, PortScaleViewModel>()
            //            .ForMember(vm => vm.Calibrations,
            //                map => map.MapFrom(x => x.Calibrations.OrderByDescending(c => c.IssuingDate)));

            //        CreateMap<PortScaleCalibration, PortScaleCalibrationViewModel>();

            //        CreateMap<ServiceOrder, ServiceOrderHeaderViewModel>()
            //            .ForMember(vm => vm.Transport,
            //                map => map.MapFrom(x => x.File.Transport.Name))
            //            .ForMember(vm => vm.Clients,
            //                map => map.MapFrom(x => x.Figures.Where(y => y.IsPrincipal).Select(z => z.Figure.Name)))
            //            .ForMember(vm => vm.Commodity,
            //                map => map.MapFrom(x => x.Commodity.ShortCode))
            //            .ForMember(vm => vm.ProductFullName,
            //                map => map.MapFrom(x => x.Commodity.Name))
            //            .ForMember(vm => vm.ProductFullNameLocal,
            //                map => map.MapFrom(x => x.Commodity.LocalName))
            //            .ForMember(vm => vm.Port,
            //                map => map.MapFrom(x => x.Operation.Port.Name))
            //            .ForMember(vm => vm.Tons,
            //                map => map.MapFrom(x => x.ExpectedTons.ToString("#,##0.000")));

            //        CreateMap<ServiceOrder, ServiceOrderListViewModel>()
            //            .ForMember(vm => vm.File,
            //                map => map.MapFrom(x => x.File.Id))
            //            .ForMember(vm => vm.Transport,
            //                map => map.MapFrom(x => x.File.Transport.Name))
            //            .ForMember(vm => vm.Nominator,
            //                map => map.MapFrom(x => string.Join(", ", x.Figures.Where(y => y.IsPrincipal).Select(z => z.Figure.Name))))
            //            .ForMember(vm => vm.ProductCategory,
            //                map => map.MapFrom(x => x.Commodity.Category))
            //            .ForMember(vm => vm.Commodity,
            //                map => map.MapFrom(x => x.Commodity.ShortCode))
            //            .ForMember(vm => vm.ProductFullName,
            //                map => map.MapFrom(x => x.Commodity.Name))
            //            .ForMember(vm => vm.ProductFullNameLocal,
            //                map => map.MapFrom(x => x.Commodity.LocalName))
            //            .ForMember(vm => vm.Port,
            //                map => map.MapFrom(x => x.Operation.Port.Name))
            //            .ForMember(vm => vm.Tons,
            //                map => map.MapFrom(x => x.ExpectedTons.ToString("#,##0.000")))
            //            .ForMember(vm => vm.OriginDestinations,
            //                map => map.MapFrom(x => string.Join(", ", x.OriginDestinations.Select(y => y.Country.Name))))
            //            .ForMember(vm => vm.Shippers,
            //                map => map.MapFrom(x => string.Join(", ", x.Figures.Where(y => y.FigureType.Equals(FigureType.Shipper)).Select(z => z.Figure.Name))))
            //            .ForMember(vm => vm.PrincipalServices,
            //                map => map.Ignore());

            //        CreateMap<ServiceOrder, ServiceOrderDetailsViewModel>()
            //            .ForMember(vm => vm.File,
            //                map => map.MapFrom(x => x.File.Id))
            //            .ForMember(vm => vm.Reference,
            //                map => map.MapFrom(x =>
            //                    $"{(DateTime)x.File.CreationDate:yyyy}/{x.Operation.Port.InternalCode}.{(x.Type.Equals(OperationType.Discharge) ? "1" : x.Type.Equals(OperationType.Load) ? "7" : "3")}.{x.FileId:D3}"))
            //            .ForMember(vm => vm.Officers,
            //                map => map.MapFrom(x => string.Join(", ", x.File.Officers.Select(y => y.ApplicationUser.UserName))))
            //            .ForMember(vm => vm.Transport,
            //                map => map.MapFrom(x => x.File.Transport.Name))
            //            .ForMember(vm => vm.Nominator,
            //                map => map.MapFrom(x => x.Figures.Where(y => y.IsPrincipal).Select(z => z.Figure.Name)))
            //            .ForMember(vm => vm.Commodity,
            //                map => map.MapFrom(x => $"{x.Commodity.ShortCode} ({x.Commodity.Name})"))
            //            .ForMember(vm => vm.Port,
            //                map => map.MapFrom(x => $"{x.Operation.Port.Name}, {x.Operation.Port.Country.LocalName}"))
            //            .ForMember(vm => vm.Eta,
            //                map => map.MapFrom(x => x.Operation.Eta))
            //            .ForMember(vm => vm.ExpectedTons,
            //                map => map.MapFrom(x => x.ExpectedTons))
            //            .ForMember(vm => vm.Instructions,
            //                map => map.MapFrom(x => x.ServiceOrderInstruction.Instruction))
            //            .ForMember(vm => vm.Remarks,
            //                map => map.MapFrom(x => x.ServiceOrderInstruction.Remarks))
            //            .ForMember(vm => vm.OriginDestinations,
            //                map => map.MapFrom(x => string.Join(", ", x.OriginDestinations.Select(y => y.Country.Name))))
            //            .ForMember(vm => vm.Figures,
            //                map => map.MapFrom(x => x.Figures.Select(y => new AdditionalFigureViewModel { FigureType = y.FigureType, FigureName = y.Figure.Name, IsPrincipal = y.IsPrincipal })))
            //            .ForMember(vm => vm.Shippers,
            //                map => map.MapFrom(x => x.Figures.Where(y => y.FigureType.Equals(FigureType.Shipper)).Select(z => new ShipperViewModel { ShipperId = z.FigureId, Tons = z.Tons, ShipperName = z.Figure.Name, IsExactQuantity = z.IsExactQuantity, IsPrincipal = z.IsPrincipal })))
            //            .ForMember(vm => vm.PrincipalServices,
            //                map => map.Ignore())
            //            .ForMember(vm => vm.Attachments,
            //                map => map.MapFrom(x => x.Attachments))
            //            .ForMember(vm => vm.CreatedBy,
            //            map => map.MapFrom(x => x.Creator.UserName))
            //            .ForMember(vm => vm.Subscribers,
            //                map => map.MapFrom(x => x.Subscribers.Select(y => y.ApplicationUserId)));

            //        CreateMap<ServiceOrder, ServiceOrderPreviewViewModel>()
            //            .ForMember(vm => vm.Transport,
            //                map => map.MapFrom(x => x.File.Transport.Name))
            //            .ForMember(vm => vm.Nominator,
            //                map => map.MapFrom(x => x.Figures.Where(y => y.IsPrincipal).Select(z => z.Figure.Name)))
            //            .ForMember(vm => vm.Commodity,
            //                map => map.MapFrom(x => $"{x.Commodity.ShortCode} ({x.Commodity.Name})"))
            //            .ForMember(vm => vm.ExpectedTons,
            //                map => map.MapFrom(x => x.ExpectedTons))
            //            .ForMember(vm => vm.Instructions,
            //                map => map.MapFrom(x => x.ServiceOrderInstruction.Instruction))
            //            .ForMember(vm => vm.Remarks,
            //                map => map.MapFrom(x => x.ServiceOrderInstruction.Remarks))
            //            .ForMember(vm => vm.OriginDestinations,
            //                map => map.MapFrom(x => string.Join(", ", x.OriginDestinations.Select(y => y.Country.Name))))
            //            .ForMember(vm => vm.Figures,
            //                map => map.MapFrom(x => x.Figures.Select(y => new AdditionalFigureViewModel { FigureType = y.FigureType, FigureName = y.Figure.Name, IsPrincipal = y.IsPrincipal })))
            //            .ForMember(vm => vm.Shippers,
            //                map => map.MapFrom(x => x.Figures.Where(y => y.FigureType.Equals(FigureType.Shipper)).Select(z => new ShipperViewModel { ShipperId = z.FigureId, Tons = z.Tons, ShipperName = z.Figure.Name, IsExactQuantity = z.IsExactQuantity, IsPrincipal = z.IsPrincipal })))
            //            .ForMember(vm => vm.PrincipalServices,
            //                map => map.Ignore());

            //        CreateMap<ServiceOrder, ServiceOrderViewModel>()
            //            .ForMember(vm => vm.BuyerId,
            //                map => map.MapFrom(x =>
            //                    x.Figures.FirstOrDefault(y => y.FigureType.Equals(FigureType.Buyer)).FigureId))
            //            .ForMember(vm => vm.BuyerIsPrincipal,
            //                map => map.MapFrom(x =>
            //                    x.Figures.FirstOrDefault(y => y.FigureType.Equals(FigureType.Buyer)).IsPrincipal))
            //            .ForMember(vm => vm.Instructions,
            //                map => map.MapFrom(x => x.ServiceOrderInstruction.Instruction))
            //            .ForMember(vm => vm.Remarks,
            //                map => map.MapFrom(x => x.ServiceOrderInstruction.Remarks))
            //            .ForMember(vm => vm.OriginDestinations,
            //                map => map.MapFrom(x => x.OriginDestinations.Select(y => y.CountryId)))
            //            .ForMember(vm => vm.AgencyId,
            //                map => map.MapFrom(x => x.Operation.AgencyId))
            //            .ForMember(vm => vm.StevedoreId,
            //                map => map.MapFrom(x => x.Operation.StevedoreId))
            //            .ForMember(vm => vm.Eta,
            //                map => map.MapFrom(x => x.Operation.Eta))
            //            .ForMember(vm => vm.PortId,
            //                map => map.MapFrom(x => x.Operation.Port.Id))
            //            .ForMember(vm => vm.Shippers,
            //                map => map.MapFrom(x => x.Figures.Where(y => y.FigureType.Equals(FigureType.Shipper))
            //                    .Select(z => new ShipperViewModel { ShipperId = z.FigureId, Tons = z.Tons, ShipperName = z.Figure.Name, IsPrincipal = z.IsPrincipal, IsExactQuantity = z.IsExactQuantity })))
            //            .ForMember(vm => vm.AdditionalFigures,
            //                map => map.MapFrom(x => x.Figures.Where(y => !new[] { FigureType.Shipper, FigureType.Buyer }.Contains(y.FigureType))
            //                    .Select(z => new AdditionalFigureViewModel { FigureId = z.FigureId, FigureType = z.FigureType, FigureName = z.Figure.Name, IsPrincipal = z.IsPrincipal })))
            //            .ForMember(vm => vm.PrincipalServices,
            //                map => map.Ignore());

            //        CreateMap<ServiceOrder, ServiceOrderOperationViewModel>()
            //            .ForMember(vm => vm.Nominator,
            //                map => map.MapFrom(x => x.Figures.Where(y => y.IsPrincipal).Select(z => z.Figure.Name)))
            //            .ForMember(vm => vm.Commodity,
            //                map => map.MapFrom(x => $"{x.Commodity.ShortCode} ({x.Commodity.Name})"))
            //            .ForMember(vm => vm.Port,
            //                map => map.MapFrom(x => $"{x.Operation.Port.Name}, {x.Operation.Port.Country.LocalName}"))
            //            .ForMember(vm => vm.PortLatitude,
            //                map => map.MapFrom(x => x.Operation.Port.Address.CoordinateLatitude))
            //            .ForMember(vm => vm.PortLongitude,
            //                map => map.MapFrom(x => x.Operation.Port.Address.CoordinateLongitude))
            //            .ForMember(vm => vm.Eta,
            //                map => map.MapFrom(x => x.Operation.Eta))
            //            .ForMember(vm => vm.Etb,
            //                map => map.MapFrom(x => x.Operation.Etb))
            //            .ForMember(vm => vm.Etc,
            //                map => map.MapFrom(x => x.Operation.Etc))
            //            .ForMember(vm => vm.CompletedDate,
            //                map => map.MapFrom(x => x.Operation.CompletedDate))
            //            .ForMember(vm => vm.ClosureDate,
            //                map => map.MapFrom(x => x.Operation.ClosureDate))
            //            .ForMember(vm => vm.LastUpdate,
            //                map => map.MapFrom(x => x.Operation.LastUpdate))
            //            .ForMember(vm => vm.ExpectedTons,
            //                map => map.MapFrom(x => x.ExpectedTons))
            //            .ForMember(vm => vm.Type,
            //                map => map.MapFrom(x => x.Type))
            //            .ForMember(vm => vm.Status,
            //                map => map.MapFrom(x => x.Operation.Status))
            //            .ForMember(vm => vm.TimeLogEntries,
            //                map => map.MapFrom(x => x.TimeLogEntries))
            //            .ForMember(vm => vm.StowagePlanQuantity,
            //                map => map.MapFrom(x => x.StowagePlanForDry.Sum(y => y.Quantity).ToString("#,##0.000")));

            //        CreateMap<ServiceOrder, ServiceOrderReportModel>()
            //            .ForMember(vm => vm.Reference,
            //                map => map.MapFrom(x =>
            //                    $"{(DateTime)x.File.CreationDate:yyyy}/{x.Operation.Port.InternalCode}.{(x.Type.Equals(OperationType.Discharge) ? "1" : x.Type.Equals(OperationType.Load) ? "7" : "3")}.{x.FileId:D3}"))
            //            .ForMember(vm => vm.Transport,
            //                map => map.MapFrom(x => x.File.Transport.Name))
            //            .ForMember(vm => vm.Nominator,
            //                map => map.MapFrom(x =>
            //                    string.Join(", ", x.Figures.Where(y => y.IsPrincipal).Select(z => z.Figure.Name))))
            //            .ForMember(vm => vm.Commodity,
            //                map => map.MapFrom(x =>
            //                    $"{x.ExpectedTons:#,##0.000} TM de {x.Commodity.LocalName}, {(x.Type.Equals(OperationType.Discharge) ? "origen:" : "destino:")} {string.Join(", ", x.OriginDestinations.Select(y => y.Country.Name))}"))
            //            .ForMember(vm => vm.Port,
            //                map => map.MapFrom(x => $"{x.Operation.Port.Name}, {x.Operation.Port.Country.LocalName}"))
            //            .ForMember(vm => vm.Eta,
            //                map => map.MapFrom(x => x.Operation.Eta != null ? ((DateTime)x.Operation.Eta).ToString("dd.MM.yyyy") : "---"))
            //            .ForMember(vm => vm.Instructions,
            //                map => map.MapFrom(x => x.ServiceOrderInstruction.Instruction))
            //            .ForMember(vm => vm.Remarks,
            //                map => map.MapFrom(x => x.ServiceOrderInstruction.Remarks))
            //            .ForMember(vm => vm.Type,
            //                map => map.MapFrom(x => x.Type.ToString()))
            //            .ForMember(vm => vm.Stevedore,
            //                map => map.MapFrom(x => x.Operation.Stevedore.Name ?? "---"))
            //            .ForMember(vm => vm.Agency,
            //                map => map.MapFrom(x => x.Operation.Agency.Name ?? "---"))
            //            .ForMember(vm => vm.Seller,
            //                map => map.MapFrom(x => x.Figures.FirstOrDefault(y => y.FigureType.Equals(FigureType.Seller)).Figure.Name ?? "---"))
            //            .ForMember(vm => vm.Receiver,
            //            map => map.MapFrom(x => x.Figures.FirstOrDefault(y => y.FigureType.Equals(FigureType.Receiver)).Figure.Name ?? "---"))
            //            .ForMember(vm => vm.PrincipalServices,
            //                map => map.Ignore());

            //        CreateMap<ServiceOrder, DischargeOperationReportModel>()
            //            .ForMember(vm => vm.Reference,
            //                map => map.MapFrom(x =>
            //                    $"{(DateTime)x.File.CreationDate:yyyy}/{x.Operation.Port.InternalCode}.{(x.Type.Equals(OperationType.Discharge) ? "1" : x.Type.Equals(OperationType.Load) ? "7" : "3")}.{x.FileId:D3}"))
            //            .ForMember(vm => vm.Client,
            //                map => map.MapFrom(x => string.Join(", ", x.Figures.Where(y => y.IsPrincipal).Select(z => z.Figure.Name).FirstOrDefault())))
            //            .ForMember(vm => vm.DoubleNomination,
            //                map => map.MapFrom(x => x.Figures.Count(y => y.IsPrincipal) != 1 ? string.Join(", ", x.Figures.Where(y => y.IsPrincipal).Select(z => z.Figure.Name).Skip(1)) : "No"))
            //            .ForMember(vm => vm.Port,
            //                map => map.MapFrom(x => $"{x.Operation.Port.Name}, {x.Operation.Port.Country.Name}"))
            //            .ForMember(vm => vm.Agency,
            //                map => map.MapFrom(x => x.Operation.Agency.Name))
            //            .ForMember(vm => vm.Commodity,
            //                map => map.MapFrom(x => $"{x.Commodity.ShortCode} ({x.Commodity.Name})"))
            //            .ForMember(vm => vm.ProductCategory,
            //                map => map.MapFrom(x => x.Commodity.Category))
            //            .ForMember(vm => vm.Origin,
            //                map => map.MapFrom(x => string.Join(", ", x.OriginDestinations.Select(y => y.Country.Name))))
            //            .ForMember(vm => vm.Quantity,
            //                map => map.MapFrom(x => x.ExpectedTons))
            //            .ForMember(vm => vm.Stevedore,
            //                map => map.MapFrom(x => x.Operation.Stevedore.Name))
            //            .ForMember(vm => vm.Etc,
            //                map => map.MapFrom(x => x.Operation.Etc != null ? ((DateTime)x.Operation.Etc).ToString("dd.MM.yyyy 'at' HH.mm") : ""))
            //            .ForMember(vm => vm.Vessel,
            //                map => map.MapFrom(x => x.File.Transport.Name))
            //            .ForMember(vm => vm.Operation,
            //                map => map.Ignore())
            //            .ForMember(vm => vm.TimeLogEntries,
            //                map => map.MapFrom(x => x.TimeLogEntries))
            //            .ForMember(vm => vm.StowagePlanEntries,
            //                map => map.MapFrom(x => x.StowagePlanForDry));

            //        CreateMap<ServiceOrderAttachment, AttachmentViewModel>()
            //            .ForMember(vm => vm.Description,
            //                map => map.MapFrom(x => x.Description))
            //            .ForMember(vm => vm.FileName,
            //                map => map.MapFrom(x => x.FileName));

            //        CreateMap<OperationStowagePlanForDry, OperationReportStowagePlanForDryModel>()
            //            .ForMember(vm => vm.StorageUnit,
            //                map => map.MapFrom(x => x.StorageUnit.Name));

            //        CreateMap<Transport, TransportListViewModel>()
            //            .ForMember(vm => vm.Flag,
            //                map => map.MapFrom(x => x.Country.Name));

            //        CreateMap<Transport, TransportViewModel>()
            //            .ForMember(vm => vm.Country,
            //                map => map.MapFrom(x => x.Country.Name))
            //            .ForMember(vm => vm.StorageUnits,
            //                map => map.MapFrom(x => x.StorageUnits.OrderBy(s => s.Name)));

            //        CreateMap<TransportStorageUnit, TransportStorageUnitViewModel>();
            //    }

            //    private static List<FactRequirementViewModel> GetFactRequirements(IEnumerable<FactRequires> types)
            //    {
            //        var allTypes = new List<FactRequirementViewModel>();

            //        foreach (FactRequires item in Enum.GetValues(typeof(FactRequires)))
            //        {
            //            allTypes.Add(new FactRequirementViewModel { Requires = item, IsSelected = types.Contains(item) });
            //        }

            //        return allTypes;
            //    }

            //    private static List<PlayerTypeViewModel> GetTypes(IEnumerable<PlayerType> types)
            //    {
            //        var allTypes = new List<PlayerTypeViewModel>();

            //        foreach (PlayerType item in Enum.GetValues(typeof(PlayerType)))
            //        {
            //            allTypes.Add(new PlayerTypeViewModel { PlayerType = item, IsSelected = types.Contains(item) });
            //        }

            //        return allTypes;
            //    }
        }
    }
}
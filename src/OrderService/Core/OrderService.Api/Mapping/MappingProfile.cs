using AutoMapper;
using eCorp.WebStore.OrderService.Api.Resources;
using eCorp.WebStore.OrderService.Domain.Models;

namespace eCorp.WebStore.OrderService.Api.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<PurchaseOrder, PurchaseOrderResource>();
            CreateMap<ShipmentOrder, ShipmentOrderResource>();
        }
    }
}

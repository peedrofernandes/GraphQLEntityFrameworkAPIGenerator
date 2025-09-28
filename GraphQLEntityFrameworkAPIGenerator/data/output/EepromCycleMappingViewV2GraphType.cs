
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WP.Cooking.GESE.WebAPI.Models;
using GraphQL.DataLoader;
using WP.Cooking.GESE.WebAPI.Repositories; 


namespace WP.Cooking.GESE.WebAPI.GraphQL.Types
{
    public partial class EepromCycleMappingViewV2GraphType : ObjectGraphType<EepromCycleMappingViewV2>
    {
        public EepromCycleMappingViewV2GraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.DataModelVersionTypeDescription, type: typeof(StringGraphType), nullable: True);
			Field(t => t.Compartment0, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.CompartmentName, type: typeof(StringGraphType), nullable: False);
			Field(t => t.KeyValue0, type: typeof(LongGraphType), nullable: True);
			Field(t => t.ConnectivityCycleKey0, type: typeof(LongGraphType), nullable: True);
			Field(t => t.KeyName0, type: typeof(StringGraphType), nullable: True);
			Field(t => t.ConnectivityCycleEnumeration0, type: typeof(IdGraphType), nullable: True);
			Field(t => t.EnumDescription, type: typeof(StringGraphType), nullable: True);
			Field(t => t.CycleMapIndex, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.IsConnected, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.HmiCycleName, type: typeof(StringGraphType), nullable: True);
			Field(t => t.IndustrialCode, type: typeof(StringGraphType), nullable: False);
			Field(t => t.SoftwarePartNumber, type: typeof(StringGraphType), nullable: True);
			Field(t => t.Version, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.HexEncoding, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ProductVariant, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.CycleMappingProductVariantDescription, type: typeof(StringGraphType), nullable: True);
            
        }
    }
}
            
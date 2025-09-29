
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
    public partial class VisualBoardTypeGraphType : ObjectGraphType<VisualBoardType>
    {
        public VisualBoardTypeGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.VisualBoardTypeId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.VisualBoardTypeDsc, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Uimicro, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.UiselectorCompressionAllowed, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.DynamicTimeToEnd, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.EcoPowerSave, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.WeightSensor, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.LongFill, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.CompressionMethod1, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.CompressionMethod2, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.CompressionMethod3, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.UieepromSize, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.HasVisualBoardTypeDisplacement, type: typeof(BoolGraphType), nullable: False);
			Field(t => t._128cyclesEnabled, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.AutoStart, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.TimeToEndTo512, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.SupportsBeforeFaultCycle, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.OffStandByEnabled, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Supports7Fabrics, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.OscillatingGroup, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.SupportsWordCapacitiveTouchParamsFingerThresholds, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.HasConnectivityPointers, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.PerformCheckOnWaterLevels, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.HasExtendedCycleSubHeading, type: typeof(BoolGraphType), nullable: False);
            
            Field<DisplayGraphType, Display>("Displays")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<DisplayGraphType>>(
                        "VisualBoardType-Display-loader",
                        async ids => 
                        {
                            var data = await dbContext.Displays
                                .Where(x => x.Display != null && ids.Contains((Guid)x.Display))
                                .Select(x => new
                                {
                                    Key = (Guid)x.Display!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.Displays);
                });
            
			
            Field<ProductTypeGraphType, ProductType>("ProductTypes")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, ProductTypeGraphType>(
                        "VisualBoardType-ProductType-loader",
                        async ids => 
                        {
                            var data = await dbContext.ProductTypes
                                .Where(x => x.ProductType.Any(c => ids.Contains(c.ProductTypeId)))
                                .Select(x => new
                                {
                                    Key = x,
                                    Values = x.ProductType,
                                })
                                .ToListAsync();

                            var lookup = data
                                .SelectMany(x => x.Values.Select(v => new { Key = v.ProductTypeId, Value = x.Key }))
                                .ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.ProductTypes);
                });
            
        }
    }
}
            
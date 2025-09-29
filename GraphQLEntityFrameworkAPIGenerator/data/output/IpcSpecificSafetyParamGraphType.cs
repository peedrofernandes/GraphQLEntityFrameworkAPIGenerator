
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
    public partial class IpcSpecificSafetyParamGraphType : ObjectGraphType<IpcSpecificSafetyParam>
    {
        public IpcSpecificSafetyParamGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.IpcSpecificSafetyParamsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.DeltaTempStartRisingTimeEvaluation, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.DeltaTempEndRisingTimeEvaluation, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.TimeMinFixedPowerDeration, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.TemperatureMonitoringAdditionalOffset, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.TemperatureMonitoringMaxTemperature, type: typeof(FloatGraphType), nullable: False);
            
            Field<InductionIpcdetailGraphType, InductionIpcdetail>("InductionIpcdetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<InductionIpcdetailGraphType>>(
                        "IpcSpecificSafetyParam-InductionIpcdetail-loader",
                        async ids => 
                        {
                            var data = await dbContext.InductionIpcdetails
                                .Where(x => x.InductionIpcdetail != null && ids.Contains((Guid)x.InductionIpcdetail))
                                .Select(x => new
                                {
                                    Key = (Guid)x.InductionIpcdetail!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.InductionIpcdetails);
                });
            
        }
    }
}
            
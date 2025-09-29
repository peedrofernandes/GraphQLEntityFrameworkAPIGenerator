
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
    public partial class SrfanSpeedCheckParameterGraphType : ObjectGraphType<SrfanSpeedCheckParameter>
    {
        public SrfanSpeedCheckParameterGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.SrFanSpeedCheckParamsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.Version, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.NumberOfCoolingFans, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.MinFanSpeed1, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.MaxFanSpeed1, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.DebounceMsForFan1, type: typeof(IdGraphType), nullable: False);
			Field(t => t.FanLoad1, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.FanGi1, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.MinFanSpeed2, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.MaxFanSpeed2, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.DebounceMsForFan2, type: typeof(IdGraphType), nullable: False);
			Field(t => t.FanLoad2, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.FanGi2, type: typeof(ShortGraphType), nullable: False);
            
            Field<SrsafetyRelevantParameterGraphType, SrsafetyRelevantParameter>("SrsafetyRelevantParameters")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<SrsafetyRelevantParameterGraphType>>(
                        "SrfanSpeedCheckParameter-SrsafetyRelevantParameter-loader",
                        async ids => 
                        {
                            var data = await dbContext.SrsafetyRelevantParameters
                                .Where(x => x.SrsafetyRelevantParameter != null && ids.Contains((Guid)x.SrsafetyRelevantParameter))
                                .Select(x => new
                                {
                                    Key = (Guid)x.SrsafetyRelevantParameter!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.SrsafetyRelevantParameters);
                });
            
        }
    }
}
            
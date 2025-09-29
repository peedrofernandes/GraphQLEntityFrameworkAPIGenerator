
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
    public partial class PrmPilotMultiDriverGraphType : ObjectGraphType<PrmPilotMultiDriver>
    {
        public PrmPilotMultiDriverGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.PilotParametersId0, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.PilotParametersId1, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.PilotParametersId2, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.PilotParametersId3, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.NumOfPins, type: typeof(ByteGraphType), nullable: False);
            
            Field<PilotTypeGraphType, PilotType>("PilotTypes")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, PilotTypeGraphType>(
                        "PrmPilotMultiDriver-PilotType-loader",
                        async ids => 
                        {
                            Expression<Func<PilotType, bool>> expr = x => !ids.Any()
                                \|\| (x.PilotTypeId0Navigation != null && ids.Contains((byte)x.PilotTypeId0Navigation))
\|\| (x.PilotTypeId1Navigation != null && ids.Contains((byte)x.PilotTypeId1Navigation))
\|\| (x.PilotTypeId2Navigation != null && ids.Contains((byte)x.PilotTypeId2Navigation))
\|\| (x.PilotTypeId3Navigation != null && ids.Contains((byte)x.PilotTypeId3Navigation));

                            var data = await dbContext.PilotTypes
                                .Where(expr)
                                .ToListAsync();

                            var lookup = data
                                .SelectMany(x => new List<byte?>()
                                {
                                    x.PilotTypeId0Navigation,
x.PilotTypeId1Navigation,
x.PilotTypeId2Navigation,
x.PilotTypeId3Navigation
                                }.OfType<byte>().Select(id => new { Key = id, Value = x }))
                                .ToLookup(x => x.Key, x => x.Value);

                            return lookup;
                        });

                    return loader.LoadAsync(context.Source.PilotTypes);
                });
            
        }
    }
}
            
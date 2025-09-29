
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
    public partial class AppConfigCoolingFanCompartmentGraphType : ObjectGraphType<AppConfigCoolingFanCompartment>
    {
        public AppConfigCoolingFanCompartmentGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.NumberOfCoolingFans, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Fan1LoadId, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Fan1SpeedGi, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Fan2LoadId, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Fan2SpeedGi, type: typeof(ShortGraphType), nullable: False);
            
            Field<AppConfigCompartmentDetailGraphType, AppConfigCompartmentDetail>("AppConfigCompartmentDetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<AppConfigCompartmentDetailGraphType>>(
                        "AppConfigCoolingFanCompartment-AppConfigCompartmentDetail-loader",
                        async ids => 
                        {
                            var data = await dbContext.AppConfigCompartmentDetails
                                .Where(x => x.AppConfigCompartmentDetail != null && ids.Contains((Guid)x.AppConfigCompartmentDetail))
                                .Select(x => new
                                {
                                    Key = (Guid)x.AppConfigCompartmentDetail!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.AppConfigCompartmentDetails);
                });
            
        }
    }
}
            

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
    public partial class UianimationFadingTypeGraphType : ObjectGraphType<UianimationFadingType>
    {
        public UianimationFadingTypeGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.InitialIntensity, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.FinalIntensity, type: typeof(ByteGraphType), nullable: False);
            
            Field<UianimationDetailGraphType, UianimationDetail>("UianimationDetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UianimationDetailGraphType>>(
                        "UianimationFadingType-UianimationDetail-loader",
                        async ids => 
                        {
                            var data = await dbContext.UianimationDetails
                                .Where(x => x.UianimationDetail != null && ids.Contains((Guid)x.UianimationDetail))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UianimationDetail!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.UianimationDetails);
                });
            
        }
    }
}
            

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
    public partial class FeedbackParameterGraphType : ObjectGraphType<FeedbackParameter>
    {
        public FeedbackParameterGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.FeedbackParametersId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.FeedbacksNumber, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.StatesNumber, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ItemsNumber, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ReadTypeId1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ReadTypePos1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ReadTypeId2, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ReadTypePos2, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Off1, type: typeof(ListGraphType<ByteGraphType>), nullable: False);
			Field(t => t.On1, type: typeof(ListGraphType<ByteGraphType>), nullable: False);
			Field(t => t.Trn1, type: typeof(ListGraphType<ByteGraphType>), nullable: False);
			Field(t => t.Alt1, type: typeof(ListGraphType<ByteGraphType>), nullable: False);
			Field(t => t.Off2, type: typeof(ListGraphType<ByteGraphType>), nullable: False);
			Field(t => t.On2, type: typeof(ListGraphType<ByteGraphType>), nullable: False);
			Field(t => t.Trn2, type: typeof(ListGraphType<ByteGraphType>), nullable: False);
			Field(t => t.Alt2, type: typeof(ListGraphType<ByteGraphType>), nullable: False);
			Field(t => t.Fbvalues, type: typeof(ListGraphType<ByteGraphType>), nullable: False);
            
            Field<LoadDetailGraphType, LoadDetail>("LoadDetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<LoadDetailGraphType>>(
                        "FeedbackParameter-LoadDetail-loader",
                        async ids => 
                        {
                            var data = await dbContext.LoadDetails
                                .Where(x => x.LoadDetail != null && ids.Contains((Guid)x.LoadDetail))
                                .Select(x => new
                                {
                                    Key = (Guid)x.LoadDetail!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.LoadDetails);
                });
            
        }
    }
}
            

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
    public partial class UidataModelKeyMappingGraphType : ObjectGraphType<UidataModelKeyMapping>
    {
        public UidataModelKeyMappingGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UidataModelKeyMappingId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.NItems, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.FunctionLabelId0, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.FunctionLabelId1, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.FunctionLabelId2, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.FunctionLabelId3, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.FunctionLabelId4, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.FunctionLabelId5, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.FunctionLabelId6, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.FunctionLabelId7, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.FunctionLabelId8, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.FunctionLabelId9, type: typeof(ByteGraphType), nullable: True);
            
            Field<ModifierGraphType, Modifier>("Modifiers")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, ModifierGraphType>(
                        "UidataModelKeyMapping-Modifier-loader",
                        async ids => 
                        {
                            Expression<Func<Modifier, bool>> expr = x => !ids.Any()
                                \|\| (x.KeyModifierId0Navigation != null && ids.Contains((Guid)x.KeyModifierId0Navigation))
\|\| (x.KeyModifierId1Navigation != null && ids.Contains((Guid)x.KeyModifierId1Navigation))
\|\| (x.KeyModifierId2Navigation != null && ids.Contains((Guid)x.KeyModifierId2Navigation))
\|\| (x.KeyModifierId3Navigation != null && ids.Contains((Guid)x.KeyModifierId3Navigation))
\|\| (x.KeyModifierId4Navigation != null && ids.Contains((Guid)x.KeyModifierId4Navigation))
\|\| (x.KeyModifierId5Navigation != null && ids.Contains((Guid)x.KeyModifierId5Navigation))
\|\| (x.KeyModifierId6Navigation != null && ids.Contains((Guid)x.KeyModifierId6Navigation))
\|\| (x.KeyModifierId7Navigation != null && ids.Contains((Guid)x.KeyModifierId7Navigation))
\|\| (x.KeyModifierId8Navigation != null && ids.Contains((Guid)x.KeyModifierId8Navigation))
\|\| (x.KeyModifierId9Navigation != null && ids.Contains((Guid)x.KeyModifierId9Navigation));

                            var data = await dbContext.Modifiers
                                .Where(expr)
                                .ToListAsync();

                            var lookup = data
                                .SelectMany(x => new List<Guid?>()
                                {
                                    x.KeyModifierId0Navigation,
x.KeyModifierId1Navigation,
x.KeyModifierId2Navigation,
x.KeyModifierId3Navigation,
x.KeyModifierId4Navigation,
x.KeyModifierId5Navigation,
x.KeyModifierId6Navigation,
x.KeyModifierId7Navigation,
x.KeyModifierId8Navigation,
x.KeyModifierId9Navigation
                                }.OfType<Guid>().Select(id => new { Key = id, Value = x }))
                                .ToLookup(x => x.Key, x => x.Value);

                            return lookup;
                        });

                    return loader.LoadAsync(context.Source.Modifiers);
                });
            
			
            Field<UidataModelTranslationDetailGraphType, UidataModelTranslationDetail>("UidataModelTranslationDetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UidataModelTranslationDetailGraphType>>(
                        "UidataModelKeyMapping-UidataModelTranslationDetail-loader",
                        async ids => 
                        {
                            var data = await dbContext.UidataModelTranslationDetails
                                .Where(x => x.UidataModelTranslationDetail != null && ids.Contains((Guid)x.UidataModelTranslationDetail))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UidataModelTranslationDetail!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.UidataModelTranslationDetails);
                });
            
        }
    }
}
            
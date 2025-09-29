
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
    public partial class SettingFileExtensionGraphType : ObjectGraphType<SettingFileExtension>
    {
        public SettingFileExtensionGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.SettingFileExtensionsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.HighStatementsExt, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.LowStatementsExt, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.OpCodeLowStatementExt, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.IsMaintainModifiersExtended, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.IsTtemodifiersExtended, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.IsHmiiopointerExtended, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.IsHmiexpansion1IopointerExtended, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.IsHmiexpansion2IopointerExtended, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.IsHmiexpansion3IopointerExtended, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.IsHmiexpansion4IopointerExtended, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.IsHmiexpansion5IopointerExtended, type: typeof(BoolGraphType), nullable: False);
            
            Field<ProjectGraphType, Project>("Projects")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<ProjectGraphType>>(
                        "SettingFileExtension-Project-loader",
                        async ids => 
                        {
                            var data = await dbContext.Projects
                                .Where(x => x.Project != null && ids.Contains((Guid)x.Project))
                                .Select(x => new
                                {
                                    Key = (Guid)x.Project!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.Projects);
                });
            
        }
    }
}
            

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
    public partial class CompiledResourceMetaDatumGraphType : ObjectGraphType<CompiledResourceMetaDatum>
    {
        public CompiledResourceMetaDatumGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.ProgramingOffset, type: typeof(IdGraphType), nullable: True);
			Field(t => t.Length, type: typeof(IdGraphType), nullable: True);
			Field(t => t.Crc, type: typeof(IdGraphType), nullable: True);
			Field(t => t.DecryptionKey, type: typeof(ListGraphType<ByteGraphType>), nullable: False);
			Field(t => t.EncryptedFileStoragePath, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
            
            Field<ProjectGraphType, Project>("Projects")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, ProjectGraphType>(
                        "CompiledResourceMetaDatum-Project-loader",
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

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.Project);
                });
            
        }
    }
}
            
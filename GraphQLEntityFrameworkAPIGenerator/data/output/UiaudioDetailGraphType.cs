
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
    public partial class UiaudioDetailGraphType : ObjectGraphType<UiaudioDetail>
    {
        public UiaudioDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UiaudioDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Name, type: typeof(StringGraphType), nullable: False);
			Field(t => t.DeviceType, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.DeviceIndex, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.UiaudioDevicePrmId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.AudioFunction, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Compartment, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.AudioIndex, type: typeof(ByteGraphType), nullable: False);
            
            Field<UiaudioConfigurationGraphType, UiaudioConfiguration>("UiaudioConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UiaudioConfigurationGraphType>>(
                        "UiaudioDetail-UiaudioConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.UiaudioConfigurationsUiaudioDetail
                                .Where(x => x.UiaudioConfigurationsId != null && ids.Contains((Guid)x.UiaudioConfigurationsId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UiaudioConfigurationsId!,
                                    Value = x.UiaudioConfigurations,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UiaudioConfigurations);
                });
            
        }
    }
}
            
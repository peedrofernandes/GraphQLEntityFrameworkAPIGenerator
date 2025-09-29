
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
    public partial class EmptyPotDetectionConfigGraphType : ObjectGraphType<EmptyPotDetectionConfig>
    {
        public EmptyPotDetectionConfigGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.EmptyPotDetectionConfigId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.EmptyPotDeratingDisengagementSlope, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.TimeFixedPowerDerating, type: typeof(FloatGraphType), nullable: False);
            
            Field<IpcControllerIpcConfigurationGraphType, IpcControllerIpcConfiguration>("IpcControllerIpcConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<IpcControllerIpcConfigurationGraphType>>(
                        "EmptyPotDetectionConfig-IpcControllerIpcConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.IpcControllerIpcConfigurations
                                .Where(x => x.IpcControllerIpcConfiguration != null && ids.Contains((Guid)x.IpcControllerIpcConfiguration))
                                .Select(x => new
                                {
                                    Key = (Guid)x.IpcControllerIpcConfiguration!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.IpcControllerIpcConfigurations);
                });
            
        }
    }
}
            
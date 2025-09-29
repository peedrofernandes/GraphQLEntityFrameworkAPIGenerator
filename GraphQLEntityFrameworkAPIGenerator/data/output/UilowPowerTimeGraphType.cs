
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
    public partial class UilowPowerTimeGraphType : ObjectGraphType<UilowPowerTime>
    {
        public UilowPowerTimeGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UilowPowerTimeId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.LowPowerTime, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.DisableLowPowerTime, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.DisableEndToOffTransitionTime, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.DisableProgrammingToOffTransitionTime, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.DisableCommunicationErrorDetection, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.EndToOffTransitionTime, type: typeof(IdGraphType), nullable: False);
			Field(t => t.ProgrammingToOffTransitionTime, type: typeof(IdGraphType), nullable: False);
			Field(t => t.CommunicationErrorDetectionTime, type: typeof(IdGraphType), nullable: False);
			Field(t => t.PasueToOffTransitionTime, type: typeof(IdGraphType), nullable: False);
			Field(t => t.DisablePasueToOffTransitionTime, type: typeof(BoolGraphType), nullable: False);
            
            Field<DisplayGraphType, Display>("Displays")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<DisplayGraphType>>(
                        "UilowPowerTime-Display-loader",
                        async ids => 
                        {
                            var data = await dbContext.Displays
                                .Where(x => x.Display != null && ids.Contains((Guid)x.Display))
                                .Select(x => new
                                {
                                    Key = (Guid)x.Display!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.Displays);
                });
            
        }
    }
}
            
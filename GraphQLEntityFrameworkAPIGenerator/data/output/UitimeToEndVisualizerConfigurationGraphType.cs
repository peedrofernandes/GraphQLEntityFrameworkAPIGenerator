
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
    public partial class UitimeToEndVisualizerConfigurationGraphType : ObjectGraphType<UitimeToEndVisualizerConfiguration>
    {
        public UitimeToEndVisualizerConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UitimeToEndVisualizerId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
            
                Field<UitimeToEndVisualizerConfigurationsUitimeToEndVisualizerDetailGraphType, UitimeToEndVisualizerConfigurationsUitimeToEndVisualizerDetail>("UitimeToEndVisualizerConfigurationsUitimeToEndVisualizerDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UitimeToEndVisualizerConfigurationsUitimeToEndVisualizerDetailGraphType>>(
                            "{ Name = EntityName "UitimeToEndVisualizerConfiguration"
  CorrespondingTable =
   Regular
     { Name = TableName "UitimeToEndVisualizerConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UitimeToEndVisualizerId"
                      IsNullable = false }; Primitive { Type = String
                                                        Name = "Description"
                                                        IsNullable = false };
         Primitive { Type = Byte
                     Name = "Status"
                     IsNullable = false }; Primitive { Type = String
                                                       Name = "Owner"
                                                       IsNullable = false };
         Primitive { Type = DateTime
                     Name = "Timestamp"
                     IsNullable = false }; Primitive { Type = Guid
                                                       Name = "RevisionGroup"
                                                       IsNullable = false };
         Primitive { Type = Int
                     Name = "Revision"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "TableTarget"
                                                       IsNullable = false };
         Primitive { Type = String
                     Name = "Notes"
                     IsNullable = true };
         Navigation
           { Type =
              TableName
                "UitimeToEndVisualizerConfigurationsUitimeToEndVisualizerDetail"
             Name =
              "UitimeToEndVisualizerConfigurationsUitimeToEndVisualizerDetails"
             IsNullable = false
             IsCollection = true }] }
  Fields =
   [{ Name = "UitimeToEndVisualizerId"
      Type = Id Guid
      IsNullable = false }; { Name = "Description"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Status"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Owner"
      Type = Primitive String
      IsNullable = false }; { Name = "Timestamp"
                              Type = Primitive DateTime
                              IsNullable = false }; { Name = "RevisionGroup"
                                                      Type = Primitive Guid
                                                      IsNullable = false };
    { Name = "Revision"
      Type = Primitive Int
      IsNullable = false }; { Name = "TableTarget"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Notes"
                                                      Type = Primitive String
                                                      IsNullable = true }]
  Relations =
   [OneToMany
      { Name =
         RelationName
           "UitimeToEndVisualizerConfigurationsUitimeToEndVisualizerDetail"
        TargetTable =
         { Name =
            TableName
              "UitimeToEndVisualizerConfigurationsUitimeToEndVisualizerDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UitimeToEndVisualizerId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "UitimeToEndVisualizerDetailId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "UitimeToEndVisualizerConfiguration"
                          Name = "UitimeToEndVisualizer"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UitimeToEndVisualizerDetail"
                          Name = "UitimeToEndVisualizerDetail"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName
           "UitimeToEndVisualizerConfigurationsUitimeToEndVisualizerDetail"
        KeyType = Guid }] }-UitimeToEndVisualizerConfigurationsUitimeToEndVisualizerDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.UitimeToEndVisualizerConfigurationsUitimeToEndVisualizerDetails
                                    .Where(x => x.UitimeToEndVisualizerConfigurationsUitimeToEndVisualizerDetail != null && ids.Contains((Guid)x.UitimeToEndVisualizerConfigurationsUitimeToEndVisualizerDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UitimeToEndVisualizerConfigurationsUitimeToEndVisualizerDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.UitimeToEndVisualizerConfigurationsUitimeToEndVisualizerDetails);
                    });
            
        }
    }
}
            
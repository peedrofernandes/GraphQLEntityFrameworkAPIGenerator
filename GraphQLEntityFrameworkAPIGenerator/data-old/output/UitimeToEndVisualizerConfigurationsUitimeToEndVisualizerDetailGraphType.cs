
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
    public partial class UitimeToEndVisualizerConfigurationsUitimeToEndVisualizerDetailGraphType : ObjectGraphType<UitimeToEndVisualizerConfigurationsUitimeToEndVisualizerDetail>
    {
        public UitimeToEndVisualizerConfigurationsUitimeToEndVisualizerDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UitimeToEndVisualizerId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.UitimeToEndVisualizerDetailId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<UitimeToEndVisualizerConfigurationGraphType, UitimeToEndVisualizerConfiguration>("UitimeToEndVisualizerConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UitimeToEndVisualizerConfigurationGraphType>(
                            "{ Name =
   EntityName "UitimeToEndVisualizerConfigurationsUitimeToEndVisualizerDetail"
  CorrespondingTable =
   Regular
     { Name =
        TableName
          "UitimeToEndVisualizerConfigurationsUitimeToEndVisualizerDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UitimeToEndVisualizerId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "UitimeToEndVisualizerDetailId"
                      IsNullable = false }; PrimaryKey { Type = Byte
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
  Fields =
   [{ Name = "UitimeToEndVisualizerId"
      Type = Id Guid
      IsNullable = false }; { Name = "UitimeToEndVisualizerDetailId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "UitimeToEndVisualizerConfiguration"
        TargetTable =
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
                         IsNullable = false };
             Primitive { Type = Guid
                         Name = "RevisionGroup"
                         IsNullable = false }; Primitive { Type = Int
                                                           Name = "Revision"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "TableTarget"
                         IsNullable = false }; Primitive { Type = String
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
        Destination = EntityName "UitimeToEndVisualizerConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UitimeToEndVisualizerDetail"
        TargetTable =
         { Name = TableName "UitimeToEndVisualizerDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UitimeToEndVisualizerDetailId"
                          IsNullable = false }; Primitive { Type = Int
                                                            Name = "BumpUpValue"
                                                            IsNullable = false };
             Primitive { Type = Int
                         Name = "BumpUpTime"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "FreezeTimeRate"
                         IsNullable = false }; Primitive { Type = Float
                                                           Name = "SpeedUpRate"
                                                           IsNullable = false };
             Primitive { Type = String
                         Name = "Description"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Status"
                                                           IsNullable = false };
             Primitive { Type = String
                         Name = "Owner"
                         IsNullable = false }; Primitive { Type = DateTime
                                                           Name = "Timestamp"
                                                           IsNullable = false };
             Primitive { Type = Guid
                         Name = "RevisionGroup"
                         IsNullable = false }; Primitive { Type = Int
                                                           Name = "Revision"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "TableTarget"
                         IsNullable = false }; Primitive { Type = String
                                                           Name = "Notes"
                                                           IsNullable = true };
             Primitive { Type = Double
                         Name = "LightFilterBeta"
                         IsNullable = false };
             Primitive { Type = Double
                         Name = "HeavyFilterBeta"
                         IsNullable = false };
             Navigation
               { Type =
                  TableName
                    "UitimeToEndVisualizerConfigurationsUitimeToEndVisualizerDetail"
                 Name =
                  "UitimeToEndVisualizerConfigurationsUitimeToEndVisualizerDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UitimeToEndVisualizerDetail"
        IsNullable = false
        KeyType = Guid }] }-UitimeToEndVisualizerConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.UitimeToEndVisualizerConfigurations
                                    .Where(x => x.UitimeToEndVisualizerConfiguration != null && ids.Contains((Guid)x.UitimeToEndVisualizerConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UitimeToEndVisualizerConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.UitimeToEndVisualizerConfiguration);
                });
            
			
                Field<UitimeToEndVisualizerDetailGraphType, UitimeToEndVisualizerDetail>("UitimeToEndVisualizerDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UitimeToEndVisualizerDetailGraphType>(
                            "{ Name =
   EntityName "UitimeToEndVisualizerConfigurationsUitimeToEndVisualizerDetail"
  CorrespondingTable =
   Regular
     { Name =
        TableName
          "UitimeToEndVisualizerConfigurationsUitimeToEndVisualizerDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UitimeToEndVisualizerId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "UitimeToEndVisualizerDetailId"
                      IsNullable = false }; PrimaryKey { Type = Byte
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
  Fields =
   [{ Name = "UitimeToEndVisualizerId"
      Type = Id Guid
      IsNullable = false }; { Name = "UitimeToEndVisualizerDetailId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "UitimeToEndVisualizerConfiguration"
        TargetTable =
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
                         IsNullable = false };
             Primitive { Type = Guid
                         Name = "RevisionGroup"
                         IsNullable = false }; Primitive { Type = Int
                                                           Name = "Revision"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "TableTarget"
                         IsNullable = false }; Primitive { Type = String
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
        Destination = EntityName "UitimeToEndVisualizerConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UitimeToEndVisualizerDetail"
        TargetTable =
         { Name = TableName "UitimeToEndVisualizerDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UitimeToEndVisualizerDetailId"
                          IsNullable = false }; Primitive { Type = Int
                                                            Name = "BumpUpValue"
                                                            IsNullable = false };
             Primitive { Type = Int
                         Name = "BumpUpTime"
                         IsNullable = false };
             Primitive { Type = Float
                         Name = "FreezeTimeRate"
                         IsNullable = false }; Primitive { Type = Float
                                                           Name = "SpeedUpRate"
                                                           IsNullable = false };
             Primitive { Type = String
                         Name = "Description"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Status"
                                                           IsNullable = false };
             Primitive { Type = String
                         Name = "Owner"
                         IsNullable = false }; Primitive { Type = DateTime
                                                           Name = "Timestamp"
                                                           IsNullable = false };
             Primitive { Type = Guid
                         Name = "RevisionGroup"
                         IsNullable = false }; Primitive { Type = Int
                                                           Name = "Revision"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "TableTarget"
                         IsNullable = false }; Primitive { Type = String
                                                           Name = "Notes"
                                                           IsNullable = true };
             Primitive { Type = Double
                         Name = "LightFilterBeta"
                         IsNullable = false };
             Primitive { Type = Double
                         Name = "HeavyFilterBeta"
                         IsNullable = false };
             Navigation
               { Type =
                  TableName
                    "UitimeToEndVisualizerConfigurationsUitimeToEndVisualizerDetail"
                 Name =
                  "UitimeToEndVisualizerConfigurationsUitimeToEndVisualizerDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UitimeToEndVisualizerDetail"
        IsNullable = false
        KeyType = Guid }] }-UitimeToEndVisualizerDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.UitimeToEndVisualizerDetails
                                    .Where(x => x.UitimeToEndVisualizerDetail != null && ids.Contains((Guid)x.UitimeToEndVisualizerDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UitimeToEndVisualizerDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.UitimeToEndVisualizerDetail);
                });
            
        }
    }
}
            
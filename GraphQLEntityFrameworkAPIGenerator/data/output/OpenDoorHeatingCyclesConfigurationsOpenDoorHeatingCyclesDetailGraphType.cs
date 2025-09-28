
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
    public partial class OpenDoorHeatingCyclesConfigurationsOpenDoorHeatingCyclesDetailGraphType : ObjectGraphType<OpenDoorHeatingCyclesConfigurationsOpenDoorHeatingCyclesDetail>
    {
        public OpenDoorHeatingCyclesConfigurationsOpenDoorHeatingCyclesDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.OpenDoorHeatingCyclesConfigId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.OpenDoorHeatingCyclesDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<OpenDoorHeatingCyclesConfigurationGraphType, OpenDoorHeatingCyclesConfiguration>("OpenDoorHeatingCyclesConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, OpenDoorHeatingCyclesConfigurationGraphType>(
                            "{ Name =
   EntityName "OpenDoorHeatingCyclesConfigurationsOpenDoorHeatingCyclesDetail"
  CorrespondingTable =
   Regular
     { Name =
        TableName
          "OpenDoorHeatingCyclesConfigurationsOpenDoorHeatingCyclesDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "OpenDoorHeatingCyclesConfigId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "OpenDoorHeatingCyclesDetailsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "OpenDoorHeatingCyclesConfiguration"
                      Name = "OpenDoorHeatingCyclesConfig"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "OpenDoorHeatingCyclesDetail"
                      Name = "OpenDoorHeatingCyclesDetails"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "OpenDoorHeatingCyclesConfigId"
      Type = Id Guid
      IsNullable = false }; { Name = "OpenDoorHeatingCyclesDetailsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "OpenDoorHeatingCyclesConfiguration"
        TargetTable =
         { Name = TableName "OpenDoorHeatingCyclesConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "OpenDoorHeatingCyclesConfigId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Code"
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
             Primitive { Type = Byte
                         Name = "Version"
                         IsNullable = false };
             Navigation { Type = TableName "MachineConfiguration"
                          Name = "MachineConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "OpenDoorHeatingCyclesConfigurationsOpenDoorHeatingCyclesDetail"
                 Name =
                  "OpenDoorHeatingCyclesConfigurationsOpenDoorHeatingCyclesDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "OpenDoorHeatingCyclesConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "OpenDoorHeatingCyclesDetail"
        TargetTable =
         { Name = TableName "OpenDoorHeatingCyclesDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "OpenDoorHeatingCyclesDetailsId"
                          IsNullable = false }; Primitive { Type = Int
                                                            Name = "CycleName"
                                                            IsNullable = false };
             Primitive { Type = String
                         Name = "Compartment"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "ConvFanFlag"
                                                           IsNullable = false };
             Navigation
               { Type =
                  TableName
                    "OpenDoorHeatingCyclesConfigurationsOpenDoorHeatingCyclesDetail"
                 Name =
                  "OpenDoorHeatingCyclesConfigurationsOpenDoorHeatingCyclesDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "OpenDoorHeatingCyclesDetail"
        IsNullable = false
        KeyType = Guid }] }-OpenDoorHeatingCyclesConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.OpenDoorHeatingCyclesConfigurations
                                    .Where(x => x.OpenDoorHeatingCyclesConfiguration != null && ids.Contains((Guid)x.OpenDoorHeatingCyclesConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.OpenDoorHeatingCyclesConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.OpenDoorHeatingCyclesConfiguration);
                });
            
			
                Field<OpenDoorHeatingCyclesDetailGraphType, OpenDoorHeatingCyclesDetail>("OpenDoorHeatingCyclesDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, OpenDoorHeatingCyclesDetailGraphType>(
                            "{ Name =
   EntityName "OpenDoorHeatingCyclesConfigurationsOpenDoorHeatingCyclesDetail"
  CorrespondingTable =
   Regular
     { Name =
        TableName
          "OpenDoorHeatingCyclesConfigurationsOpenDoorHeatingCyclesDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "OpenDoorHeatingCyclesConfigId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "OpenDoorHeatingCyclesDetailsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "OpenDoorHeatingCyclesConfiguration"
                      Name = "OpenDoorHeatingCyclesConfig"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "OpenDoorHeatingCyclesDetail"
                      Name = "OpenDoorHeatingCyclesDetails"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "OpenDoorHeatingCyclesConfigId"
      Type = Id Guid
      IsNullable = false }; { Name = "OpenDoorHeatingCyclesDetailsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "OpenDoorHeatingCyclesConfiguration"
        TargetTable =
         { Name = TableName "OpenDoorHeatingCyclesConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "OpenDoorHeatingCyclesConfigId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Code"
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
             Primitive { Type = Byte
                         Name = "Version"
                         IsNullable = false };
             Navigation { Type = TableName "MachineConfiguration"
                          Name = "MachineConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "OpenDoorHeatingCyclesConfigurationsOpenDoorHeatingCyclesDetail"
                 Name =
                  "OpenDoorHeatingCyclesConfigurationsOpenDoorHeatingCyclesDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "OpenDoorHeatingCyclesConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "OpenDoorHeatingCyclesDetail"
        TargetTable =
         { Name = TableName "OpenDoorHeatingCyclesDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "OpenDoorHeatingCyclesDetailsId"
                          IsNullable = false }; Primitive { Type = Int
                                                            Name = "CycleName"
                                                            IsNullable = false };
             Primitive { Type = String
                         Name = "Compartment"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "ConvFanFlag"
                                                           IsNullable = false };
             Navigation
               { Type =
                  TableName
                    "OpenDoorHeatingCyclesConfigurationsOpenDoorHeatingCyclesDetail"
                 Name =
                  "OpenDoorHeatingCyclesConfigurationsOpenDoorHeatingCyclesDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "OpenDoorHeatingCyclesDetail"
        IsNullable = false
        KeyType = Guid }] }-OpenDoorHeatingCyclesDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.OpenDoorHeatingCyclesDetails
                                    .Where(x => x.OpenDoorHeatingCyclesDetail != null && ids.Contains((Guid)x.OpenDoorHeatingCyclesDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.OpenDoorHeatingCyclesDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.OpenDoorHeatingCyclesDetail);
                });
            
        }
    }
}
            

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
    public partial class MicrowavePowerTableConfigurationsMicrowavePowerTableDetailGraphType : ObjectGraphType<MicrowavePowerTableConfigurationsMicrowavePowerTableDetail>
    {
        public MicrowavePowerTableConfigurationsMicrowavePowerTableDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.MicrowavePowerTableConfigId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.MicrowavePowerTableDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<MicrowavePowerTableConfigurationGraphType, MicrowavePowerTableConfiguration>("MicrowavePowerTableConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, MicrowavePowerTableConfigurationGraphType>(
                            "{ Name = EntityName "MicrowavePowerTableConfigurationsMicrowavePowerTableDetail"
  CorrespondingTable =
   Regular
     { Name =
        TableName "MicrowavePowerTableConfigurationsMicrowavePowerTableDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "MicrowavePowerTableConfigId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "MicrowavePowerTableDetailsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "MicrowavePowerTableConfiguration"
                      Name = "MicrowavePowerTableConfig"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "MicrowavePowerTableDetail"
                      Name = "MicrowavePowerTableDetails"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "MicrowavePowerTableConfigId"
      Type = Id Guid
      IsNullable = false }; { Name = "MicrowavePowerTableDetailsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "MicrowavePowerTableConfiguration"
        TargetTable =
         { Name = TableName "MicrowavePowerTableConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "MicrowavePowerTableConfigId"
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
             Primitive { Type = Float
                         Name = "MwdutyPeriod"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Version"
                                                           IsNullable = false };
             Navigation { Type = TableName "MachineConfiguration"
                          Name = "MachineConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "MicrowavePowerTableConfigurationsMicrowavePowerTableDetail"
                 Name =
                  "MicrowavePowerTableConfigurationsMicrowavePowerTableDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "MicrowavePowerTableConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "MicrowavePowerTableDetail"
        TargetTable =
         { Name = TableName "MicrowavePowerTableDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "MicrowavePowerTableDetailsId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "PowerLabel"
                                                            IsNullable = false };
             Primitive { Type = Float
                         Name = "Smpsduty"
                         IsNullable = false }; Primitive { Type = Float
                                                           Name = "OnTime"
                                                           IsNullable = false };
             Navigation
               { Type =
                  TableName
                    "MicrowavePowerTableConfigurationsMicrowavePowerTableDetail"
                 Name =
                  "MicrowavePowerTableConfigurationsMicrowavePowerTableDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "MicrowavePowerTableDetail"
        IsNullable = false
        KeyType = Guid }] }-MicrowavePowerTableConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.MicrowavePowerTableConfigurations
                                    .Where(x => x.MicrowavePowerTableConfiguration != null && ids.Contains((Guid)x.MicrowavePowerTableConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.MicrowavePowerTableConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.MicrowavePowerTableConfiguration);
                });
            
			
                Field<MicrowavePowerTableDetailGraphType, MicrowavePowerTableDetail>("MicrowavePowerTableDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, MicrowavePowerTableDetailGraphType>(
                            "{ Name = EntityName "MicrowavePowerTableConfigurationsMicrowavePowerTableDetail"
  CorrespondingTable =
   Regular
     { Name =
        TableName "MicrowavePowerTableConfigurationsMicrowavePowerTableDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "MicrowavePowerTableConfigId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "MicrowavePowerTableDetailsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "MicrowavePowerTableConfiguration"
                      Name = "MicrowavePowerTableConfig"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "MicrowavePowerTableDetail"
                      Name = "MicrowavePowerTableDetails"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "MicrowavePowerTableConfigId"
      Type = Id Guid
      IsNullable = false }; { Name = "MicrowavePowerTableDetailsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "MicrowavePowerTableConfiguration"
        TargetTable =
         { Name = TableName "MicrowavePowerTableConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "MicrowavePowerTableConfigId"
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
             Primitive { Type = Float
                         Name = "MwdutyPeriod"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Version"
                                                           IsNullable = false };
             Navigation { Type = TableName "MachineConfiguration"
                          Name = "MachineConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "MicrowavePowerTableConfigurationsMicrowavePowerTableDetail"
                 Name =
                  "MicrowavePowerTableConfigurationsMicrowavePowerTableDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "MicrowavePowerTableConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "MicrowavePowerTableDetail"
        TargetTable =
         { Name = TableName "MicrowavePowerTableDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "MicrowavePowerTableDetailsId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "PowerLabel"
                                                            IsNullable = false };
             Primitive { Type = Float
                         Name = "Smpsduty"
                         IsNullable = false }; Primitive { Type = Float
                                                           Name = "OnTime"
                                                           IsNullable = false };
             Navigation
               { Type =
                  TableName
                    "MicrowavePowerTableConfigurationsMicrowavePowerTableDetail"
                 Name =
                  "MicrowavePowerTableConfigurationsMicrowavePowerTableDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "MicrowavePowerTableDetail"
        IsNullable = false
        KeyType = Guid }] }-MicrowavePowerTableDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.MicrowavePowerTableDetails
                                    .Where(x => x.MicrowavePowerTableDetail != null && ids.Contains((Guid)x.MicrowavePowerTableDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.MicrowavePowerTableDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.MicrowavePowerTableDetail);
                });
            
        }
    }
}
            
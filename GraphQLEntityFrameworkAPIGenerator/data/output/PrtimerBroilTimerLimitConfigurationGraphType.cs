
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
    public partial class PrtimerBroilTimerLimitConfigurationGraphType : ObjectGraphType<PrtimerBroilTimerLimitConfiguration>
    {
        public PrtimerBroilTimerLimitConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.PrtimerBroilTimerLimitConfigId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Version, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.NumberOfLevels, type: typeof(ByteGraphType), nullable: False);
            
                Field<PrtimerBroilConfigurationGraphType, PrtimerBroilConfiguration>("PrtimerBroilConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PrtimerBroilConfigurationGraphType>>(
                            "{ Name = EntityName "PrtimerBroilTimerLimitConfiguration"
  CorrespondingTable =
   Regular
     { Name = TableName "PrtimerBroilTimerLimitConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "PrtimerBroilTimerLimitConfigId"
                      IsNullable = false }; Primitive { Type = Byte
                                                        Name = "Version"
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
                     Name = "NumberOfLevels"
                     IsNullable = false };
         Navigation { Type = TableName "PrtimerBroilConfiguration"
                      Name = "PrtimerBroilConfigurations"
                      IsNullable = false
                      IsCollection = true };
         Navigation
           { Type =
              TableName
                "PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetail"
             Name =
              "PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetails"
             IsNullable = false
             IsCollection = true }] }
  Fields =
   [{ Name = "PrtimerBroilTimerLimitConfigId"
      Type = Id Guid
      IsNullable = false }; { Name = "Version"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Description"
                                                      Type = Primitive String
                                                      IsNullable = false };
    { Name = "Status"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Owner"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Timestamp"
                                                      Type = Primitive DateTime
                                                      IsNullable = false };
    { Name = "RevisionGroup"
      Type = Primitive Guid
      IsNullable = false }; { Name = "Revision"
                              Type = Primitive Int
                              IsNullable = false }; { Name = "TableTarget"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Notes"
      Type = Primitive String
      IsNullable = true }; { Name = "NumberOfLevels"
                             Type = Primitive Byte
                             IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "PrtimerBroilConfiguration"
        TargetTable =
         { Name = TableName "PrtimerBroilConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerBroilConfigId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Version"
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
                         Name = "NumberOfLevels"
                         IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "PrtimerBroilTimerLimitConfigId"
                          IsNullable = true };
             Navigation { Type = TableName "PowerReductionTimerConfiguration"
                          Name = "PowerReductionTimerConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfiguration"
                 Name =
                  "PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfigurations"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "PrtimerBroilTimerLimitConfiguration"
                          Name = "PrtimerBroilTimerLimitConfig"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "PrtimerBroilConfiguration"
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName
           "PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetail"
        TargetTable =
         { Name =
            TableName
              "PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerBroilTimerLimitConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "PrtimerBroilTimerLimitDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "PrtimerBroilTimerLimitConfiguration"
                          Name = "PrtimerBroilTimerLimitConfig"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "PrtimerBroilTimerLimitDetail"
                          Name = "PrtimerBroilTimerLimitDetails"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName
           "PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetail"
        KeyType = Guid }] }-PrtimerBroilConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.PrtimerBroilConfigurations
                                    .Where(x => x.PrtimerBroilConfiguration != null && ids.Contains((Guid)x.PrtimerBroilConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PrtimerBroilConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.PrtimerBroilConfigurations);
                    });
            
			
                Field<PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetailGraphType, PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetail>("PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetailGraphType>>(
                            "{ Name = EntityName "PrtimerBroilTimerLimitConfiguration"
  CorrespondingTable =
   Regular
     { Name = TableName "PrtimerBroilTimerLimitConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "PrtimerBroilTimerLimitConfigId"
                      IsNullable = false }; Primitive { Type = Byte
                                                        Name = "Version"
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
                     Name = "NumberOfLevels"
                     IsNullable = false };
         Navigation { Type = TableName "PrtimerBroilConfiguration"
                      Name = "PrtimerBroilConfigurations"
                      IsNullable = false
                      IsCollection = true };
         Navigation
           { Type =
              TableName
                "PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetail"
             Name =
              "PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetails"
             IsNullable = false
             IsCollection = true }] }
  Fields =
   [{ Name = "PrtimerBroilTimerLimitConfigId"
      Type = Id Guid
      IsNullable = false }; { Name = "Version"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Description"
                                                      Type = Primitive String
                                                      IsNullable = false };
    { Name = "Status"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Owner"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Timestamp"
                                                      Type = Primitive DateTime
                                                      IsNullable = false };
    { Name = "RevisionGroup"
      Type = Primitive Guid
      IsNullable = false }; { Name = "Revision"
                              Type = Primitive Int
                              IsNullable = false }; { Name = "TableTarget"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Notes"
      Type = Primitive String
      IsNullable = true }; { Name = "NumberOfLevels"
                             Type = Primitive Byte
                             IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "PrtimerBroilConfiguration"
        TargetTable =
         { Name = TableName "PrtimerBroilConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerBroilConfigId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Version"
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
                         Name = "NumberOfLevels"
                         IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "PrtimerBroilTimerLimitConfigId"
                          IsNullable = true };
             Navigation { Type = TableName "PowerReductionTimerConfiguration"
                          Name = "PowerReductionTimerConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfiguration"
                 Name =
                  "PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfigurations"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "PrtimerBroilTimerLimitConfiguration"
                          Name = "PrtimerBroilTimerLimitConfig"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "PrtimerBroilConfiguration"
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName
           "PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetail"
        TargetTable =
         { Name =
            TableName
              "PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerBroilTimerLimitConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "PrtimerBroilTimerLimitDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "PrtimerBroilTimerLimitConfiguration"
                          Name = "PrtimerBroilTimerLimitConfig"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "PrtimerBroilTimerLimitDetail"
                          Name = "PrtimerBroilTimerLimitDetails"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName
           "PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetail"
        KeyType = Guid }] }-PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetails
                                    .Where(x => x.PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetail != null && ids.Contains((Guid)x.PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.PrtimerBroilTimerLimitConfigurationPrtimerBroilTimerLimitDetails);
                    });
            
        }
    }
}
            
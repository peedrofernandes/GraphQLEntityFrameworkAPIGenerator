
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
    public partial class PrtimerMagnetronTimerLimitConfigurationGraphType : ObjectGraphType<PrtimerMagnetronTimerLimitConfiguration>
    {
        public PrtimerMagnetronTimerLimitConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.PrtimerMagnetronTimerLimitConfigId, type: typeof(GuidGraphType), nullable: False);
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
            
                Field<PrtimerMagnetronConfigurationGraphType, PrtimerMagnetronConfiguration>("PrtimerMagnetronConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PrtimerMagnetronConfigurationGraphType>>(
                            "{ Name = EntityName "PrtimerMagnetronTimerLimitConfiguration"
  CorrespondingTable =
   Regular
     { Name = TableName "PrtimerMagnetronTimerLimitConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "PrtimerMagnetronTimerLimitConfigId"
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
         Navigation { Type = TableName "PrtimerMagnetronConfiguration"
                      Name = "PrtimerMagnetronConfigurations"
                      IsNullable = false
                      IsCollection = true };
         Navigation
           { Type =
              TableName
                "PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetail"
             Name =
              "PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetails"
             IsNullable = false
             IsCollection = true }] }
  Fields =
   [{ Name = "PrtimerMagnetronTimerLimitConfigId"
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
      { Name = RelationName "PrtimerMagnetronConfiguration"
        TargetTable =
         { Name = TableName "PrtimerMagnetronConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerMagnetronConfigId"
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
                          Name = "PrtimerMagnetronTimerLimitConfigId"
                          IsNullable = true };
             Navigation { Type = TableName "PowerReductionTimerConfiguration"
                          Name = "PowerReductionTimerConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfiguration"
                 Name =
                  "PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfigurations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "PrtimerMagnetronTimerLimitConfiguration"
                 Name = "PrtimerMagnetronTimerLimitConfig"
                 IsNullable = true
                 IsCollection = false }] }
        Destination = EntityName "PrtimerMagnetronConfiguration"
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName
           "PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetail"
        TargetTable =
         { Name =
            TableName
              "PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerMagnetronTimerLimitConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "PrtimerMagnetronTimerLimitDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation
               { Type = TableName "PrtimerMagnetronTimerLimitConfiguration"
                 Name = "PrtimerMagnetronTimerLimitConfig"
                 IsNullable = false
                 IsCollection = false };
             Navigation { Type = TableName "PrtimerMagnetronTimerLimitDetail"
                          Name = "PrtimerMagnetronTimerLimitDetails"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName
           "PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetail"
        KeyType = Guid }] }-PrtimerMagnetronConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.PrtimerMagnetronConfigurations
                                    .Where(x => x.PrtimerMagnetronConfiguration != null && ids.Contains((Guid)x.PrtimerMagnetronConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PrtimerMagnetronConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.PrtimerMagnetronConfigurations);
                    });
            
			
                Field<PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetailGraphType, PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetail>("PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetailGraphType>>(
                            "{ Name = EntityName "PrtimerMagnetronTimerLimitConfiguration"
  CorrespondingTable =
   Regular
     { Name = TableName "PrtimerMagnetronTimerLimitConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "PrtimerMagnetronTimerLimitConfigId"
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
         Navigation { Type = TableName "PrtimerMagnetronConfiguration"
                      Name = "PrtimerMagnetronConfigurations"
                      IsNullable = false
                      IsCollection = true };
         Navigation
           { Type =
              TableName
                "PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetail"
             Name =
              "PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetails"
             IsNullable = false
             IsCollection = true }] }
  Fields =
   [{ Name = "PrtimerMagnetronTimerLimitConfigId"
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
      { Name = RelationName "PrtimerMagnetronConfiguration"
        TargetTable =
         { Name = TableName "PrtimerMagnetronConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerMagnetronConfigId"
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
                          Name = "PrtimerMagnetronTimerLimitConfigId"
                          IsNullable = true };
             Navigation { Type = TableName "PowerReductionTimerConfiguration"
                          Name = "PowerReductionTimerConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfiguration"
                 Name =
                  "PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfigurations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "PrtimerMagnetronTimerLimitConfiguration"
                 Name = "PrtimerMagnetronTimerLimitConfig"
                 IsNullable = true
                 IsCollection = false }] }
        Destination = EntityName "PrtimerMagnetronConfiguration"
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName
           "PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetail"
        TargetTable =
         { Name =
            TableName
              "PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerMagnetronTimerLimitConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "PrtimerMagnetronTimerLimitDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation
               { Type = TableName "PrtimerMagnetronTimerLimitConfiguration"
                 Name = "PrtimerMagnetronTimerLimitConfig"
                 IsNullable = false
                 IsCollection = false };
             Navigation { Type = TableName "PrtimerMagnetronTimerLimitDetail"
                          Name = "PrtimerMagnetronTimerLimitDetails"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName
           "PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetail"
        KeyType = Guid }] }-PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetails
                                    .Where(x => x.PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetail != null && ids.Contains((Guid)x.PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.PrtimerMagnetronTimerLimitConfigurationPrtimerMagnetronTimerLimitDetails);
                    });
            
        }
    }
}
            
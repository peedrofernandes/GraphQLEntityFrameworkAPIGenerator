
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
    public partial class PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetailGraphType : ObjectGraphType<PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetail>
    {
        public PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.PrtimerMagnetronUserPhaseNameConfigId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.PrtimerMagnetronUserPhaseNameDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<PrtimerMagnetronUserPhaseNameConfigurationGraphType, PrtimerMagnetronUserPhaseNameConfiguration>("PrtimerMagnetronUserPhaseNameConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, PrtimerMagnetronUserPhaseNameConfigurationGraphType>(
                            "{ Name =
   EntityName
     "PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetail"
  CorrespondingTable =
   Regular
     { Name =
        TableName
          "PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "PrtimerMagnetronUserPhaseNameConfigId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "PrtimerMagnetronUserPhaseNameDetailsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation
           { Type = TableName "PrtimerMagnetronUserPhaseNameConfiguration"
             Name = "PrtimerMagnetronUserPhaseNameConfig"
             IsNullable = false
             IsCollection = false };
         Navigation { Type = TableName "PrtimerMagnetronUserPhaseNameDetail"
                      Name = "PrtimerMagnetronUserPhaseNameDetails"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "PrtimerMagnetronUserPhaseNameConfigId"
      Type = Id Guid
      IsNullable = false }; { Name = "PrtimerMagnetronUserPhaseNameDetailsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "PrtimerMagnetronUserPhaseNameConfiguration"
        TargetTable =
         { Name = TableName "PrtimerMagnetronUserPhaseNameConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerMagnetronUserPhaseNameConfigId"
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
             Primitive { Type = Short
                         Name = "UserPhaseName"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "NumberOfLevels"
                         IsNullable = false };
             Navigation
               { Type =
                  TableName
                    "PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfiguration"
                 Name =
                  "PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfigurations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetail"
                 Name =
                  "PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "PrtimerMagnetronUserPhaseNameConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerMagnetronUserPhaseNameDetail"
        TargetTable =
         { Name = TableName "PrtimerMagnetronUserPhaseNameDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerMagnetronUserPhaseNameDetailsId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "TimerIncrement"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "PowerLimit"
                                                           IsNullable = false };
             Navigation
               { Type =
                  TableName
                    "PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetail"
                 Name =
                  "PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "PrtimerMagnetronUserPhaseNameDetail"
        IsNullable = false
        KeyType = Guid }] }-PrtimerMagnetronUserPhaseNameConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.PrtimerMagnetronUserPhaseNameConfigurations
                                    .Where(x => x.PrtimerMagnetronUserPhaseNameConfiguration != null && ids.Contains((Guid)x.PrtimerMagnetronUserPhaseNameConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PrtimerMagnetronUserPhaseNameConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.PrtimerMagnetronUserPhaseNameConfiguration);
                });
            
			
                Field<PrtimerMagnetronUserPhaseNameDetailGraphType, PrtimerMagnetronUserPhaseNameDetail>("PrtimerMagnetronUserPhaseNameDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, PrtimerMagnetronUserPhaseNameDetailGraphType>(
                            "{ Name =
   EntityName
     "PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetail"
  CorrespondingTable =
   Regular
     { Name =
        TableName
          "PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "PrtimerMagnetronUserPhaseNameConfigId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "PrtimerMagnetronUserPhaseNameDetailsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation
           { Type = TableName "PrtimerMagnetronUserPhaseNameConfiguration"
             Name = "PrtimerMagnetronUserPhaseNameConfig"
             IsNullable = false
             IsCollection = false };
         Navigation { Type = TableName "PrtimerMagnetronUserPhaseNameDetail"
                      Name = "PrtimerMagnetronUserPhaseNameDetails"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "PrtimerMagnetronUserPhaseNameConfigId"
      Type = Id Guid
      IsNullable = false }; { Name = "PrtimerMagnetronUserPhaseNameDetailsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "PrtimerMagnetronUserPhaseNameConfiguration"
        TargetTable =
         { Name = TableName "PrtimerMagnetronUserPhaseNameConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerMagnetronUserPhaseNameConfigId"
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
             Primitive { Type = Short
                         Name = "UserPhaseName"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "NumberOfLevels"
                         IsNullable = false };
             Navigation
               { Type =
                  TableName
                    "PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfiguration"
                 Name =
                  "PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfigurations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetail"
                 Name =
                  "PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "PrtimerMagnetronUserPhaseNameConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerMagnetronUserPhaseNameDetail"
        TargetTable =
         { Name = TableName "PrtimerMagnetronUserPhaseNameDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerMagnetronUserPhaseNameDetailsId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "TimerIncrement"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "PowerLimit"
                                                           IsNullable = false };
             Navigation
               { Type =
                  TableName
                    "PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetail"
                 Name =
                  "PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "PrtimerMagnetronUserPhaseNameDetail"
        IsNullable = false
        KeyType = Guid }] }-PrtimerMagnetronUserPhaseNameDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.PrtimerMagnetronUserPhaseNameDetails
                                    .Where(x => x.PrtimerMagnetronUserPhaseNameDetail != null && ids.Contains((Guid)x.PrtimerMagnetronUserPhaseNameDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PrtimerMagnetronUserPhaseNameDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.PrtimerMagnetronUserPhaseNameDetail);
                });
            
        }
    }
}
            
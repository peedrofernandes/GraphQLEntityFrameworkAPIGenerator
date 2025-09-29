
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
    public partial class PrtimerMagnetronUserPhaseNameConfigurationGraphType : ObjectGraphType<PrtimerMagnetronUserPhaseNameConfiguration>
    {
        public PrtimerMagnetronUserPhaseNameConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.PrtimerMagnetronUserPhaseNameConfigId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.UserPhaseName, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.NumberOfLevels, type: typeof(ByteGraphType), nullable: False);
            
                Field<PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfigurationGraphType, PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfiguration>("PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfigurationGraphType>>(
                            "{ Name = EntityName "PrtimerMagnetronUserPhaseNameConfiguration"
  CorrespondingTable =
   Regular
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
                     IsNullable = true }; Primitive { Type = Short
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
  Fields =
   [{ Name = "PrtimerMagnetronUserPhaseNameConfigId"
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
                                                      IsNullable = true };
    { Name = "UserPhaseName"
      Type = Primitive Short
      IsNullable = false }; { Name = "NumberOfLevels"
                              Type = Primitive Byte
                              IsNullable = false }]
  Relations =
   [OneToMany
      { Name =
         RelationName
           "PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfiguration"
        TargetTable =
         { Name =
            TableName
              "PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerMagnetronConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "PrtimerMagnetronUserPhaseNameConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "PrtimerMagnetronConfiguration"
                          Name = "PrtimerMagnetronConfig"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type = TableName "PrtimerMagnetronUserPhaseNameConfiguration"
                 Name = "PrtimerMagnetronUserPhaseNameConfig"
                 IsNullable = false
                 IsCollection = false }] }
        Destination =
         EntityName
           "PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfiguration"
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName
           "PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetail"
        TargetTable =
         { Name =
            TableName
              "PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerMagnetronUserPhaseNameConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "PrtimerMagnetronUserPhaseNameDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
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
        Destination =
         EntityName
           "PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetail"
        KeyType = Guid }] }-PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfigurations
                                    .Where(x => x.PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfiguration != null && ids.Contains((Guid)x.PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfigurations);
                    });
            
			
                Field<PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetailGraphType, PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetail>("PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetailGraphType>>(
                            "{ Name = EntityName "PrtimerMagnetronUserPhaseNameConfiguration"
  CorrespondingTable =
   Regular
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
                     IsNullable = true }; Primitive { Type = Short
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
  Fields =
   [{ Name = "PrtimerMagnetronUserPhaseNameConfigId"
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
                                                      IsNullable = true };
    { Name = "UserPhaseName"
      Type = Primitive Short
      IsNullable = false }; { Name = "NumberOfLevels"
                              Type = Primitive Byte
                              IsNullable = false }]
  Relations =
   [OneToMany
      { Name =
         RelationName
           "PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfiguration"
        TargetTable =
         { Name =
            TableName
              "PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerMagnetronConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "PrtimerMagnetronUserPhaseNameConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "PrtimerMagnetronConfiguration"
                          Name = "PrtimerMagnetronConfig"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type = TableName "PrtimerMagnetronUserPhaseNameConfiguration"
                 Name = "PrtimerMagnetronUserPhaseNameConfig"
                 IsNullable = false
                 IsCollection = false }] }
        Destination =
         EntityName
           "PrtimerMagnetronConfigurationPrtimerMagnetronUserPhaseNameConfiguration"
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName
           "PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetail"
        TargetTable =
         { Name =
            TableName
              "PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerMagnetronUserPhaseNameConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "PrtimerMagnetronUserPhaseNameDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
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
        Destination =
         EntityName
           "PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetail"
        KeyType = Guid }] }-PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetails
                                    .Where(x => x.PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetail != null && ids.Contains((Guid)x.PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.PrtimerMagnetronUserPhaseNameConfigurationPrtimerMagnetronUserPhaseNameDetails);
                    });
            
        }
    }
}
            
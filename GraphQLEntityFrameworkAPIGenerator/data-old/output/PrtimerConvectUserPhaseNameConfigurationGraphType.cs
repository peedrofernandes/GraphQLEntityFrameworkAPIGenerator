
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
    public partial class PrtimerConvectUserPhaseNameConfigurationGraphType : ObjectGraphType<PrtimerConvectUserPhaseNameConfiguration>
    {
        public PrtimerConvectUserPhaseNameConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.PrtimerConvectUserPhaseNameConfigId, type: typeof(GuidGraphType), nullable: False);
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
            
                Field<PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfigurationGraphType, PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfiguration>("PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfigurationGraphType>>(
                            "{ Name = EntityName "PrtimerConvectUserPhaseNameConfiguration"
  CorrespondingTable =
   Regular
     { Name = TableName "PrtimerConvectUserPhaseNameConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "PrtimerConvectUserPhaseNameConfigId"
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
                "PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfiguration"
             Name =
              "PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfigurations"
             IsNullable = false
             IsCollection = true };
         Navigation
           { Type =
              TableName
                "PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetail"
             Name =
              "PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetails"
             IsNullable = false
             IsCollection = true }] }
  Fields =
   [{ Name = "PrtimerConvectUserPhaseNameConfigId"
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
           "PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfiguration"
        TargetTable =
         { Name =
            TableName
              "PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerConvectConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "PrtimerConvectUserPhaseNameConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "PrtimerConvectConfiguration"
                          Name = "PrtimerConvectConfig"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type = TableName "PrtimerConvectUserPhaseNameConfiguration"
                 Name = "PrtimerConvectUserPhaseNameConfig"
                 IsNullable = false
                 IsCollection = false }] }
        Destination =
         EntityName
           "PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfiguration"
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName
           "PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetail"
        TargetTable =
         { Name =
            TableName
              "PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerConvectUserPhaseNameConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "PrtimerConvectUserPhaseNameDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation
               { Type = TableName "PrtimerConvectUserPhaseNameConfiguration"
                 Name = "PrtimerConvectUserPhaseNameConfig"
                 IsNullable = false
                 IsCollection = false };
             Navigation { Type = TableName "PrtimerConvectUserPhaseNameDetail"
                          Name = "PrtimerConvectUserPhaseNameDetails"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName
           "PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetail"
        KeyType = Guid }] }-PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfigurations
                                    .Where(x => x.PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfiguration != null && ids.Contains((Guid)x.PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfigurations);
                    });
            
			
                Field<PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetailGraphType, PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetail>("PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetailGraphType>>(
                            "{ Name = EntityName "PrtimerConvectUserPhaseNameConfiguration"
  CorrespondingTable =
   Regular
     { Name = TableName "PrtimerConvectUserPhaseNameConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "PrtimerConvectUserPhaseNameConfigId"
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
                "PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfiguration"
             Name =
              "PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfigurations"
             IsNullable = false
             IsCollection = true };
         Navigation
           { Type =
              TableName
                "PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetail"
             Name =
              "PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetails"
             IsNullable = false
             IsCollection = true }] }
  Fields =
   [{ Name = "PrtimerConvectUserPhaseNameConfigId"
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
           "PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfiguration"
        TargetTable =
         { Name =
            TableName
              "PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerConvectConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "PrtimerConvectUserPhaseNameConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "PrtimerConvectConfiguration"
                          Name = "PrtimerConvectConfig"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type = TableName "PrtimerConvectUserPhaseNameConfiguration"
                 Name = "PrtimerConvectUserPhaseNameConfig"
                 IsNullable = false
                 IsCollection = false }] }
        Destination =
         EntityName
           "PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfiguration"
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName
           "PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetail"
        TargetTable =
         { Name =
            TableName
              "PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerConvectUserPhaseNameConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "PrtimerConvectUserPhaseNameDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation
               { Type = TableName "PrtimerConvectUserPhaseNameConfiguration"
                 Name = "PrtimerConvectUserPhaseNameConfig"
                 IsNullable = false
                 IsCollection = false };
             Navigation { Type = TableName "PrtimerConvectUserPhaseNameDetail"
                          Name = "PrtimerConvectUserPhaseNameDetails"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName
           "PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetail"
        KeyType = Guid }] }-PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetails
                                    .Where(x => x.PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetail != null && ids.Contains((Guid)x.PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetails);
                    });
            
        }
    }
}
            
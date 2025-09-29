
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
    public partial class PrtimerBroilUserPhaseNameConfigurationGraphType : ObjectGraphType<PrtimerBroilUserPhaseNameConfiguration>
    {
        public PrtimerBroilUserPhaseNameConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.PrtimerBroilUserPhaseNameConfigId, type: typeof(GuidGraphType), nullable: False);
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
            
                Field<PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfigurationGraphType, PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfiguration>("PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfigurationGraphType>>(
                            "{ Name = EntityName "PrtimerBroilUserPhaseNameConfiguration"
  CorrespondingTable =
   Regular
     { Name = TableName "PrtimerBroilUserPhaseNameConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "PrtimerBroilUserPhaseNameConfigId"
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
                "PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfiguration"
             Name =
              "PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfigurations"
             IsNullable = false
             IsCollection = true };
         Navigation
           { Type =
              TableName
                "PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetail"
             Name =
              "PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetails"
             IsNullable = false
             IsCollection = true }] }
  Fields =
   [{ Name = "PrtimerBroilUserPhaseNameConfigId"
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
           "PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfiguration"
        TargetTable =
         { Name =
            TableName
              "PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerBroilConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "PrtimerBroilUserPhaseNameConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "PrtimerBroilConfiguration"
                          Name = "PrtimerBroilConfig"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type = TableName "PrtimerBroilUserPhaseNameConfiguration"
                 Name = "PrtimerBroilUserPhaseNameConfig"
                 IsNullable = false
                 IsCollection = false }] }
        Destination =
         EntityName
           "PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfiguration"
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName
           "PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetail"
        TargetTable =
         { Name =
            TableName
              "PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerBroilUserPhaseNameConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "PrtimerBroilUserPhaseNameDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation
               { Type = TableName "PrtimerBroilUserPhaseNameConfiguration"
                 Name = "PrtimerBroilUserPhaseNameConfig"
                 IsNullable = false
                 IsCollection = false };
             Navigation { Type = TableName "PrtimerBroilUserPhaseNameDetail"
                          Name = "PrtimerBroilUserPhaseNameDetails"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName
           "PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetail"
        KeyType = Guid }] }-PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfigurations
                                    .Where(x => x.PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfiguration != null && ids.Contains((Guid)x.PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfigurations);
                    });
            
			
                Field<PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetailGraphType, PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetail>("PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetailGraphType>>(
                            "{ Name = EntityName "PrtimerBroilUserPhaseNameConfiguration"
  CorrespondingTable =
   Regular
     { Name = TableName "PrtimerBroilUserPhaseNameConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "PrtimerBroilUserPhaseNameConfigId"
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
                "PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfiguration"
             Name =
              "PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfigurations"
             IsNullable = false
             IsCollection = true };
         Navigation
           { Type =
              TableName
                "PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetail"
             Name =
              "PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetails"
             IsNullable = false
             IsCollection = true }] }
  Fields =
   [{ Name = "PrtimerBroilUserPhaseNameConfigId"
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
           "PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfiguration"
        TargetTable =
         { Name =
            TableName
              "PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerBroilConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "PrtimerBroilUserPhaseNameConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "PrtimerBroilConfiguration"
                          Name = "PrtimerBroilConfig"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type = TableName "PrtimerBroilUserPhaseNameConfiguration"
                 Name = "PrtimerBroilUserPhaseNameConfig"
                 IsNullable = false
                 IsCollection = false }] }
        Destination =
         EntityName
           "PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfiguration"
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName
           "PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetail"
        TargetTable =
         { Name =
            TableName
              "PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerBroilUserPhaseNameConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "PrtimerBroilUserPhaseNameDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation
               { Type = TableName "PrtimerBroilUserPhaseNameConfiguration"
                 Name = "PrtimerBroilUserPhaseNameConfig"
                 IsNullable = false
                 IsCollection = false };
             Navigation { Type = TableName "PrtimerBroilUserPhaseNameDetail"
                          Name = "PrtimerBroilUserPhaseNameDetails"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName
           "PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetail"
        KeyType = Guid }] }-PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetails
                                    .Where(x => x.PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetail != null && ids.Contains((Guid)x.PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetails);
                    });
            
        }
    }
}
            
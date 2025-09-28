
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
    public partial class DebugDisplacementConfigurationGraphType : ObjectGraphType<DebugDisplacementConfiguration>
    {
        public DebugDisplacementConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.DebugDisplacementConfigurationsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.FlagOneDataType, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.DataType, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
            
                Field<DebugDisplacementConfigurationsDebugDataDetailGraphType, DebugDisplacementConfigurationsDebugDataDetail>("DebugDisplacementConfigurationsDebugDataDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<DebugDisplacementConfigurationsDebugDataDetailGraphType>>(
                            "{ Name = EntityName "DebugDisplacementConfiguration"
  CorrespondingTable =
   Regular
     { Name = TableName "DebugDisplacementConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "DebugDisplacementConfigurationsId"
                      IsNullable = false }; Primitive { Type = String
                                                        Name = "Description"
                                                        IsNullable = false };
         Primitive { Type = Byte
                     Name = "Status"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "FlagOneDataType"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "DataType"
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
           { Type = TableName "DebugDisplacementConfigurationsDebugDataDetail"
             Name = "DebugDisplacementConfigurationsDebugDataDetails"
             IsNullable = false
             IsCollection = true };
         Navigation
           { Type =
              TableName
                "DebugPointerConfigurationsDebugDisplacementConfiguration"
             Name = "DebugPointerConfigurationsDebugDisplacementConfigurations"
             IsNullable = false
             IsCollection = true }] }
  Fields =
   [{ Name = "DebugDisplacementConfigurationsId"
      Type = Id Guid
      IsNullable = false }; { Name = "Description"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Status"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "FlagOneDataType"
      Type = Primitive Bool
      IsNullable = false }; { Name = "DataType"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Owner"
                                                      Type = Primitive String
                                                      IsNullable = false };
    { Name = "Timestamp"
      Type = Primitive DateTime
      IsNullable = false }; { Name = "RevisionGroup"
                              Type = Primitive Guid
                              IsNullable = false }; { Name = "Revision"
                                                      Type = Primitive Int
                                                      IsNullable = false };
    { Name = "TableTarget"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Notes"
                              Type = Primitive String
                              IsNullable = true }]
  Relations =
   [OneToMany
      { Name = RelationName "DebugDisplacementConfigurationsDebugDataDetail"
        TargetTable =
         { Name = TableName "DebugDisplacementConfigurationsDebugDataDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "DebugDisplacementConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "DebugDataDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "DebugDataDetail"
                          Name = "DebugDataDetails"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "DebugDisplacementConfiguration"
                          Name = "DebugDisplacementConfigurations"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName "DebugDisplacementConfigurationsDebugDataDetail"
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName "DebugPointerConfigurationsDebugDisplacementConfiguration"
        TargetTable =
         { Name =
            TableName "DebugPointerConfigurationsDebugDisplacementConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "DebugPointerConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "DebugDisplacementConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "DebugDisplacementConfiguration"
                          Name = "DebugDisplacementConfigurations"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "DebugPointerConfiguration"
                          Name = "DebugPointerConfigurations"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName "DebugPointerConfigurationsDebugDisplacementConfiguration"
        KeyType = Guid }] }-DebugDisplacementConfigurationsDebugDataDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.DebugDisplacementConfigurationsDebugDataDetails
                                    .Where(x => x.DebugDisplacementConfigurationsDebugDataDetail != null && ids.Contains((Guid)x.DebugDisplacementConfigurationsDebugDataDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.DebugDisplacementConfigurationsDebugDataDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.DebugDisplacementConfigurationsDebugDataDetails);
                    });
            
			
                Field<DebugPointerConfigurationsDebugDisplacementConfigurationGraphType, DebugPointerConfigurationsDebugDisplacementConfiguration>("DebugPointerConfigurationsDebugDisplacementConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<DebugPointerConfigurationsDebugDisplacementConfigurationGraphType>>(
                            "{ Name = EntityName "DebugDisplacementConfiguration"
  CorrespondingTable =
   Regular
     { Name = TableName "DebugDisplacementConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "DebugDisplacementConfigurationsId"
                      IsNullable = false }; Primitive { Type = String
                                                        Name = "Description"
                                                        IsNullable = false };
         Primitive { Type = Byte
                     Name = "Status"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "FlagOneDataType"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "DataType"
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
           { Type = TableName "DebugDisplacementConfigurationsDebugDataDetail"
             Name = "DebugDisplacementConfigurationsDebugDataDetails"
             IsNullable = false
             IsCollection = true };
         Navigation
           { Type =
              TableName
                "DebugPointerConfigurationsDebugDisplacementConfiguration"
             Name = "DebugPointerConfigurationsDebugDisplacementConfigurations"
             IsNullable = false
             IsCollection = true }] }
  Fields =
   [{ Name = "DebugDisplacementConfigurationsId"
      Type = Id Guid
      IsNullable = false }; { Name = "Description"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Status"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "FlagOneDataType"
      Type = Primitive Bool
      IsNullable = false }; { Name = "DataType"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Owner"
                                                      Type = Primitive String
                                                      IsNullable = false };
    { Name = "Timestamp"
      Type = Primitive DateTime
      IsNullable = false }; { Name = "RevisionGroup"
                              Type = Primitive Guid
                              IsNullable = false }; { Name = "Revision"
                                                      Type = Primitive Int
                                                      IsNullable = false };
    { Name = "TableTarget"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Notes"
                              Type = Primitive String
                              IsNullable = true }]
  Relations =
   [OneToMany
      { Name = RelationName "DebugDisplacementConfigurationsDebugDataDetail"
        TargetTable =
         { Name = TableName "DebugDisplacementConfigurationsDebugDataDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "DebugDisplacementConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "DebugDataDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "DebugDataDetail"
                          Name = "DebugDataDetails"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "DebugDisplacementConfiguration"
                          Name = "DebugDisplacementConfigurations"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName "DebugDisplacementConfigurationsDebugDataDetail"
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName "DebugPointerConfigurationsDebugDisplacementConfiguration"
        TargetTable =
         { Name =
            TableName "DebugPointerConfigurationsDebugDisplacementConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "DebugPointerConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "DebugDisplacementConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "DebugDisplacementConfiguration"
                          Name = "DebugDisplacementConfigurations"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "DebugPointerConfiguration"
                          Name = "DebugPointerConfigurations"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName "DebugPointerConfigurationsDebugDisplacementConfiguration"
        KeyType = Guid }] }-DebugPointerConfigurationsDebugDisplacementConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.DebugPointerConfigurationsDebugDisplacementConfigurations
                                    .Where(x => x.DebugPointerConfigurationsDebugDisplacementConfiguration != null && ids.Contains((Guid)x.DebugPointerConfigurationsDebugDisplacementConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.DebugPointerConfigurationsDebugDisplacementConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.DebugPointerConfigurationsDebugDisplacementConfigurations);
                    });
            
        }
    }
}
            
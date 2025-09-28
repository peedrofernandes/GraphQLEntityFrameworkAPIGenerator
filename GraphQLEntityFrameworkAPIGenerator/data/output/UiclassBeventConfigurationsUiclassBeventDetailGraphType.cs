
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
    public partial class UiclassBeventConfigurationsUiclassBeventDetailGraphType : ObjectGraphType<UiclassBeventConfigurationsUiclassBeventDetail>
    {
        public UiclassBeventConfigurationsUiclassBeventDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UiclassBeventConfigurationId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.UiclassBeventDetailId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<UiclassBeventConfigurationGraphType, UiclassBeventConfiguration>("UiclassBeventConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UiclassBeventConfigurationGraphType>(
                            "{ Name = EntityName "UiclassBeventConfigurationsUiclassBeventDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "UiclassBeventConfigurationsUiclassBeventDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UiclassBeventConfigurationId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "UiclassBeventDetailId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "UiclassBeventConfiguration"
                      Name = "UiclassBeventConfiguration"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "UiclassBeventDetail"
                      Name = "UiclassBeventDetail"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "UiclassBeventConfigurationId"
      Type = Id Guid
      IsNullable = false }; { Name = "UiclassBeventDetailId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "UiclassBeventConfiguration"
        TargetTable =
         { Name = TableName "UiclassBeventConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiclassBeventConfigurationId"
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
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type =
                  TableName "UiclassBeventConfigurationsUiclassBeventDetail"
                 Name = "UiclassBeventConfigurationsUiclassBeventDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UiclassBeventConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UiclassBeventDetail"
        TargetTable =
         { Name = TableName "UiclassBeventDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiclassBeventDetailId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "SrinputId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "SrinputPos"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "Compartment"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Srevent"
                                                           IsNullable = false };
             Navigation { Type = TableName "UigenericInputReadType"
                          Name = "Srinput"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type =
                  TableName "UiclassBeventConfigurationsUiclassBeventDetail"
                 Name = "UiclassBeventConfigurationsUiclassBeventDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UiclassBeventDetail"
        IsNullable = false
        KeyType = Guid }] }-UiclassBeventConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.UiclassBeventConfigurations
                                    .Where(x => x.UiclassBeventConfiguration != null && ids.Contains((Guid)x.UiclassBeventConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UiclassBeventConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.UiclassBeventConfiguration);
                });
            
			
                Field<UiclassBeventDetailGraphType, UiclassBeventDetail>("UiclassBeventDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UiclassBeventDetailGraphType>(
                            "{ Name = EntityName "UiclassBeventConfigurationsUiclassBeventDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "UiclassBeventConfigurationsUiclassBeventDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UiclassBeventConfigurationId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "UiclassBeventDetailId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "UiclassBeventConfiguration"
                      Name = "UiclassBeventConfiguration"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "UiclassBeventDetail"
                      Name = "UiclassBeventDetail"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "UiclassBeventConfigurationId"
      Type = Id Guid
      IsNullable = false }; { Name = "UiclassBeventDetailId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "UiclassBeventConfiguration"
        TargetTable =
         { Name = TableName "UiclassBeventConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiclassBeventConfigurationId"
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
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type =
                  TableName "UiclassBeventConfigurationsUiclassBeventDetail"
                 Name = "UiclassBeventConfigurationsUiclassBeventDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UiclassBeventConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UiclassBeventDetail"
        TargetTable =
         { Name = TableName "UiclassBeventDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiclassBeventDetailId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "SrinputId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "SrinputPos"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "Compartment"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Srevent"
                                                           IsNullable = false };
             Navigation { Type = TableName "UigenericInputReadType"
                          Name = "Srinput"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type =
                  TableName "UiclassBeventConfigurationsUiclassBeventDetail"
                 Name = "UiclassBeventConfigurationsUiclassBeventDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UiclassBeventDetail"
        IsNullable = false
        KeyType = Guid }] }-UiclassBeventDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.UiclassBeventDetails
                                    .Where(x => x.UiclassBeventDetail != null && ids.Contains((Guid)x.UiclassBeventDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UiclassBeventDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.UiclassBeventDetail);
                });
            
        }
    }
}
            
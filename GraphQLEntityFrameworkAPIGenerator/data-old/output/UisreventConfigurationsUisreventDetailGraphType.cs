
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
    public partial class UisreventConfigurationsUisreventDetailGraphType : ObjectGraphType<UisreventConfigurationsUisreventDetail>
    {
        public UisreventConfigurationsUisreventDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UisreventConfigurationId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.UisreventDetailId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<UisreventConfigurationGraphType, UisreventConfiguration>("UisreventConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UisreventConfigurationGraphType>(
                            "{ Name = EntityName "UisreventConfigurationsUisreventDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "UisreventConfigurationsUisreventDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UisreventConfigurationId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "UisreventDetailId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "UisreventConfiguration"
                      Name = "UisreventConfiguration"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "UisreventDetail"
                      Name = "UisreventDetail"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "UisreventConfigurationId"
      Type = Id Guid
      IsNullable = false }; { Name = "UisreventDetailId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "UisreventConfiguration"
        TargetTable =
         { Name = TableName "UisreventConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UisreventConfigurationId"
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
             Navigation { Type = TableName "Display"
                          Name = "Displays"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type = TableName "UisreventConfigurationsUisreventDetail"
                 Name = "UisreventConfigurationsUisreventDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UisreventConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UisreventDetail"
        TargetTable =
         { Name = TableName "UisreventDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UisreventDetailId"
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
             ForeignKey { Type = Guid
                          Name = "SreventPrmId"
                          IsNullable = true };
             Navigation { Type = TableName "UigenericInputReadType"
                          Name = "Srinput"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type = TableName "UisreventConfigurationsUisreventDetail"
                 Name = "UisreventConfigurationsUisreventDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UisreventDetail"
        IsNullable = false
        KeyType = Guid }] }-UisreventConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.UisreventConfigurations
                                    .Where(x => x.UisreventConfiguration != null && ids.Contains((Guid)x.UisreventConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UisreventConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.UisreventConfiguration);
                });
            
			
                Field<UisreventDetailGraphType, UisreventDetail>("UisreventDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UisreventDetailGraphType>(
                            "{ Name = EntityName "UisreventConfigurationsUisreventDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "UisreventConfigurationsUisreventDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UisreventConfigurationId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "UisreventDetailId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "UisreventConfiguration"
                      Name = "UisreventConfiguration"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "UisreventDetail"
                      Name = "UisreventDetail"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "UisreventConfigurationId"
      Type = Id Guid
      IsNullable = false }; { Name = "UisreventDetailId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "UisreventConfiguration"
        TargetTable =
         { Name = TableName "UisreventConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UisreventConfigurationId"
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
             Navigation { Type = TableName "Display"
                          Name = "Displays"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type = TableName "UisreventConfigurationsUisreventDetail"
                 Name = "UisreventConfigurationsUisreventDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UisreventConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UisreventDetail"
        TargetTable =
         { Name = TableName "UisreventDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UisreventDetailId"
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
             ForeignKey { Type = Guid
                          Name = "SreventPrmId"
                          IsNullable = true };
             Navigation { Type = TableName "UigenericInputReadType"
                          Name = "Srinput"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type = TableName "UisreventConfigurationsUisreventDetail"
                 Name = "UisreventConfigurationsUisreventDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UisreventDetail"
        IsNullable = false
        KeyType = Guid }] }-UisreventDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.UisreventDetails
                                    .Where(x => x.UisreventDetail != null && ids.Contains((Guid)x.UisreventDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UisreventDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.UisreventDetail);
                });
            
        }
    }
}
            

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
    public partial class UigenericInputConfigurationsUigenericInputDetailGraphType : ObjectGraphType<UigenericInputConfigurationsUigenericInputDetail>
    {
        public UigenericInputConfigurationsUigenericInputDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UigenericInputConfigurationId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.UigenericInputDetailId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<UigenericInputConfigurationGraphType, UigenericInputConfiguration>("UigenericInputConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UigenericInputConfigurationGraphType>(
                            "{ Name = EntityName "UigenericInputConfigurationsUigenericInputDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "UigenericInputConfigurationsUigenericInputDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UigenericInputConfigurationId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "UigenericInputDetailId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "UigenericInputConfiguration"
                      Name = "UigenericInputConfiguration"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "UigenericInputDetail"
                      Name = "UigenericInputDetail"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "UigenericInputConfigurationId"
      Type = Id Guid
      IsNullable = false }; { Name = "UigenericInputDetailId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "UigenericInputConfiguration"
        TargetTable =
         { Name = TableName "UigenericInputConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UigenericInputConfigurationId"
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
             ForeignKey { Type = Guid
                          Name = "UiinputEventMappingConfigurationId"
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
               { Type =
                  TableName "UigenericInputConfigurationsUigenericInputDetail"
                 Name = "UigenericInputConfigurationsUigenericInputDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "UiinputEventMappingConfiguration"
                          Name = "UiinputEventMappingConfiguration"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "UigenericInputConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UigenericInputDetail"
        TargetTable =
         { Name = TableName "UigenericInputDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UigenericInputDetailId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "UiinputId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "LlireadTypeId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "GireadTypePosition"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "LlireadTypePosition"
                         IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "ParametersId"
                          IsNullable = true };
             Navigation { Type = TableName "ReadType"
                          Name = "LlireadType"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type =
                  TableName "UigenericInputConfigurationsUigenericInputDetail"
                 Name = "UigenericInputConfigurationsUigenericInputDetails"
                 IsNullable = false
                 IsCollection = true }; Navigation { Type = TableName "Uiinput"
                                                     Name = "Uiinput"
                                                     IsNullable = false
                                                     IsCollection = false }] }
        Destination = EntityName "UigenericInputDetail"
        IsNullable = false
        KeyType = Guid }] }-UigenericInputConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.UigenericInputConfigurations
                                    .Where(x => x.UigenericInputConfiguration != null && ids.Contains((Guid)x.UigenericInputConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UigenericInputConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.UigenericInputConfiguration);
                });
            
			
                Field<UigenericInputDetailGraphType, UigenericInputDetail>("UigenericInputDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UigenericInputDetailGraphType>(
                            "{ Name = EntityName "UigenericInputConfigurationsUigenericInputDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "UigenericInputConfigurationsUigenericInputDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UigenericInputConfigurationId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "UigenericInputDetailId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "UigenericInputConfiguration"
                      Name = "UigenericInputConfiguration"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "UigenericInputDetail"
                      Name = "UigenericInputDetail"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "UigenericInputConfigurationId"
      Type = Id Guid
      IsNullable = false }; { Name = "UigenericInputDetailId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "UigenericInputConfiguration"
        TargetTable =
         { Name = TableName "UigenericInputConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UigenericInputConfigurationId"
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
             ForeignKey { Type = Guid
                          Name = "UiinputEventMappingConfigurationId"
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
               { Type =
                  TableName "UigenericInputConfigurationsUigenericInputDetail"
                 Name = "UigenericInputConfigurationsUigenericInputDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "UiinputEventMappingConfiguration"
                          Name = "UiinputEventMappingConfiguration"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "UigenericInputConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UigenericInputDetail"
        TargetTable =
         { Name = TableName "UigenericInputDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UigenericInputDetailId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "UiinputId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "LlireadTypeId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "GireadTypePosition"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "LlireadTypePosition"
                         IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "ParametersId"
                          IsNullable = true };
             Navigation { Type = TableName "ReadType"
                          Name = "LlireadType"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type =
                  TableName "UigenericInputConfigurationsUigenericInputDetail"
                 Name = "UigenericInputConfigurationsUigenericInputDetails"
                 IsNullable = false
                 IsCollection = true }; Navigation { Type = TableName "Uiinput"
                                                     Name = "Uiinput"
                                                     IsNullable = false
                                                     IsCollection = false }] }
        Destination = EntityName "UigenericInputDetail"
        IsNullable = false
        KeyType = Guid }] }-UigenericInputDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.UigenericInputDetails
                                    .Where(x => x.UigenericInputDetail != null && ids.Contains((Guid)x.UigenericInputDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UigenericInputDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.UigenericInputDetail);
                });
            
        }
    }
}
            
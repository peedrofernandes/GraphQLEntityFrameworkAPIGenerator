
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
    public partial class UidefaultPinConfigurationsUidefaultPinDetailGraphType : ObjectGraphType<UidefaultPinConfigurationsUidefaultPinDetail>
    {
        public UidefaultPinConfigurationsUidefaultPinDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UidefaultPinConfigurationId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.UidefaultPinDetailId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<UidefaultPinConfigurationGraphType, UidefaultPinConfiguration>("UidefaultPinConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UidefaultPinConfigurationGraphType>(
                            "{ Name = EntityName "UidefaultPinConfigurationsUidefaultPinDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "UidefaultPinConfigurationsUidefaultPinDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UidefaultPinConfigurationId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "UidefaultPinDetailId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "UidefaultPinConfiguration"
                      Name = "UidefaultPinConfiguration"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "UidefaultPinDetail"
                      Name = "UidefaultPinDetail"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "UidefaultPinConfigurationId"
      Type = Id Guid
      IsNullable = false }; { Name = "UidefaultPinDetailId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "UidefaultPinConfiguration"
        TargetTable =
         { Name = TableName "UidefaultPinConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UidefaultPinConfigurationId"
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
             Navigation
               { Type = TableName "UidefaultPinConfigurationsUidefaultPinDetail"
                 Name = "UidefaultPinConfigurationsUidefaultPinDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UidefaultPinConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UidefaultPinDetail"
        TargetTable =
         { Name = TableName "UidefaultPinDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UidefaultPinDetailId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "VirtualPinNumber"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "High"
                                                           IsNullable = false };
             ForeignKey { Type = Short
                          Name = "GpioPinTypeId"
                          IsNullable = false };
             Navigation { Type = TableName "DefaultGpioPinType"
                          Name = "GpioPinType"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type = TableName "UidefaultPinConfigurationsUidefaultPinDetail"
                 Name = "UidefaultPinConfigurationsUidefaultPinDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UidefaultPinDetail"
        IsNullable = false
        KeyType = Guid }] }-UidefaultPinConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.UidefaultPinConfigurations
                                    .Where(x => x.UidefaultPinConfiguration != null && ids.Contains((Guid)x.UidefaultPinConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UidefaultPinConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.UidefaultPinConfiguration);
                });
            
			
                Field<UidefaultPinDetailGraphType, UidefaultPinDetail>("UidefaultPinDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UidefaultPinDetailGraphType>(
                            "{ Name = EntityName "UidefaultPinConfigurationsUidefaultPinDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "UidefaultPinConfigurationsUidefaultPinDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UidefaultPinConfigurationId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "UidefaultPinDetailId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "UidefaultPinConfiguration"
                      Name = "UidefaultPinConfiguration"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "UidefaultPinDetail"
                      Name = "UidefaultPinDetail"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "UidefaultPinConfigurationId"
      Type = Id Guid
      IsNullable = false }; { Name = "UidefaultPinDetailId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "UidefaultPinConfiguration"
        TargetTable =
         { Name = TableName "UidefaultPinConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UidefaultPinConfigurationId"
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
             Navigation
               { Type = TableName "UidefaultPinConfigurationsUidefaultPinDetail"
                 Name = "UidefaultPinConfigurationsUidefaultPinDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UidefaultPinConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UidefaultPinDetail"
        TargetTable =
         { Name = TableName "UidefaultPinDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UidefaultPinDetailId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "VirtualPinNumber"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "High"
                                                           IsNullable = false };
             ForeignKey { Type = Short
                          Name = "GpioPinTypeId"
                          IsNullable = false };
             Navigation { Type = TableName "DefaultGpioPinType"
                          Name = "GpioPinType"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type = TableName "UidefaultPinConfigurationsUidefaultPinDetail"
                 Name = "UidefaultPinConfigurationsUidefaultPinDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UidefaultPinDetail"
        IsNullable = false
        KeyType = Guid }] }-UidefaultPinDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.UidefaultPinDetails
                                    .Where(x => x.UidefaultPinDetail != null && ids.Contains((Guid)x.UidefaultPinDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UidefaultPinDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.UidefaultPinDetail);
                });
            
        }
    }
}
            
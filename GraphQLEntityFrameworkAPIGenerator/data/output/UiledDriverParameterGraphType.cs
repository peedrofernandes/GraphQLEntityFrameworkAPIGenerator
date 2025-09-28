
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
    public partial class UiledDriverParameterGraphType : ObjectGraphType<UiledDriverParameter>
    {
        public UiledDriverParameterGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UiledDriverParametersId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.LedName, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Parameter1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Parameter2, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Parameter3, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
            
                Field<UiledDriverTypeGraphType, UiledDriverType>("UiledDriverTypes")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, UiledDriverTypeGraphType>(
                            "{ Name = EntityName "UiledDriverParameter"
  CorrespondingTable =
   Regular
     { Name = TableName "UiledDriverParameter"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UiledDriverParametersId"
                      IsNullable = false }; Primitive { Type = String
                                                        Name = "Description"
                                                        IsNullable = false };
         Primitive { Type = String
                     Name = "LedName"
                     IsNullable = false }; ForeignKey { Type = Byte
                                                        Name = "LedTypeId"
                                                        IsNullable = false };
         Primitive { Type = Byte
                     Name = "Parameter1"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Parameter2"
                                                       IsNullable = true };
         Primitive { Type = Byte
                     Name = "Parameter3"
                     IsNullable = true }; Primitive { Type = Byte
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
         Navigation { Type = TableName "UiledDriverType"
                      Name = "LedType"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "UiledConfigurationsUiledDriverParameter"
                      Name = "UiledConfigurationsUiledDriverParameters"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "UiledDriverParametersId"
      Type = Id Guid
      IsNullable = false }; { Name = "Description"
                              Type = Primitive String
                              IsNullable = false }; { Name = "LedName"
                                                      Type = Primitive String
                                                      IsNullable = false };
    { Name = "Parameter1"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Parameter2"
                              Type = Primitive Byte
                              IsNullable = true }; { Name = "Parameter3"
                                                     Type = Primitive Byte
                                                     IsNullable = true };
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
      IsNullable = true }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "UiledDriverType"
        TargetTable =
         { Name = TableName "UiledDriverType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "LedTypeId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "LedTypeDescription"
                         IsNullable = false };
             Navigation { Type = TableName "UiledDriverParameter"
                          Name = "UiledDriverParameters"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "UiledDriverType"
        IsNullable = false
        KeyType = Byte };
    OneToMany
      { Name = RelationName "UiledConfigurationsUiledDriverParameter"
        TargetTable =
         { Name = TableName "UiledConfigurationsUiledDriverParameter"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiledConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "UiledDriverParametersId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "UiledConfiguration"
                          Name = "UiledConfigurations"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UiledDriverParameter"
                          Name = "UiledDriverParameters"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "UiledConfigurationsUiledDriverParameter"
        KeyType = Guid }] }-UiledDriverType-loader",
                            async ids => 
                            {
                                var data = await dbContext.UiledDriverTypes
                                    .Where(x => x.UiledDriverType != null && ids.Contains((byte)x.UiledDriverType))
                                    .Select(x => new
                                    {
                                        Key = (byte)x.UiledDriverType!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.UiledDriverType);
                });
            
			
                Field<UiledConfigurationsUiledDriverParameterGraphType, UiledConfigurationsUiledDriverParameter>("UiledConfigurationsUiledDriverParameters")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UiledConfigurationsUiledDriverParameterGraphType>>(
                            "{ Name = EntityName "UiledDriverParameter"
  CorrespondingTable =
   Regular
     { Name = TableName "UiledDriverParameter"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UiledDriverParametersId"
                      IsNullable = false }; Primitive { Type = String
                                                        Name = "Description"
                                                        IsNullable = false };
         Primitive { Type = String
                     Name = "LedName"
                     IsNullable = false }; ForeignKey { Type = Byte
                                                        Name = "LedTypeId"
                                                        IsNullable = false };
         Primitive { Type = Byte
                     Name = "Parameter1"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Parameter2"
                                                       IsNullable = true };
         Primitive { Type = Byte
                     Name = "Parameter3"
                     IsNullable = true }; Primitive { Type = Byte
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
         Navigation { Type = TableName "UiledDriverType"
                      Name = "LedType"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "UiledConfigurationsUiledDriverParameter"
                      Name = "UiledConfigurationsUiledDriverParameters"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "UiledDriverParametersId"
      Type = Id Guid
      IsNullable = false }; { Name = "Description"
                              Type = Primitive String
                              IsNullable = false }; { Name = "LedName"
                                                      Type = Primitive String
                                                      IsNullable = false };
    { Name = "Parameter1"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Parameter2"
                              Type = Primitive Byte
                              IsNullable = true }; { Name = "Parameter3"
                                                     Type = Primitive Byte
                                                     IsNullable = true };
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
      IsNullable = true }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "UiledDriverType"
        TargetTable =
         { Name = TableName "UiledDriverType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "LedTypeId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "LedTypeDescription"
                         IsNullable = false };
             Navigation { Type = TableName "UiledDriverParameter"
                          Name = "UiledDriverParameters"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "UiledDriverType"
        IsNullable = false
        KeyType = Byte };
    OneToMany
      { Name = RelationName "UiledConfigurationsUiledDriverParameter"
        TargetTable =
         { Name = TableName "UiledConfigurationsUiledDriverParameter"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiledConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "UiledDriverParametersId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "UiledConfiguration"
                          Name = "UiledConfigurations"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UiledDriverParameter"
                          Name = "UiledDriverParameters"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "UiledConfigurationsUiledDriverParameter"
        KeyType = Guid }] }-UiledConfigurationsUiledDriverParameter-loader",
                            async ids => 
                            {
                                var data = await dbContext.UiledConfigurationsUiledDriverParameters
                                    .Where(x => x.UiledConfigurationsUiledDriverParameter != null && ids.Contains((Guid)x.UiledConfigurationsUiledDriverParameter))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UiledConfigurationsUiledDriverParameter!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.UiledConfigurationsUiledDriverParameters);
                    });
            
        }
    }
}
            
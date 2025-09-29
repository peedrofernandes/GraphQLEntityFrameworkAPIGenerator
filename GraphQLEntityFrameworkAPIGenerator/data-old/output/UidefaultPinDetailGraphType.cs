
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
    public partial class UidefaultPinDetailGraphType : ObjectGraphType<UidefaultPinDetail>
    {
        public UidefaultPinDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UidefaultPinDetailId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.VirtualPinNumber, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.High, type: typeof(BoolGraphType), nullable: False);
            
                Field<DefaultGpioPinTypeGraphType, DefaultGpioPinType>("DefaultGpioPinTypes")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<short, DefaultGpioPinTypeGraphType>(
                            "{ Name = EntityName "UidefaultPinDetail"
  CorrespondingTable =
   Regular
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
  Fields =
   [{ Name = "UidefaultPinDetailId"
      Type = Id Guid
      IsNullable = false }; { Name = "VirtualPinNumber"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "High"
                                                      Type = Primitive Bool
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "DefaultGpioPinType"
        TargetTable =
         { Name = TableName "DefaultGpioPinType"
           Properties =
            [PrimaryKey { Type = Short
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Description"
                                                            IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsOutput"
                         IsNullable = false };
             Navigation { Type = TableName "DefaultPinDetail"
                          Name = "DefaultPinDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UidefaultPinDetail"
                          Name = "UidefaultPinDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "DefaultGpioPinType"
        IsNullable = false
        KeyType = Short };
    OneToMany
      { Name = RelationName "UidefaultPinConfigurationsUidefaultPinDetail"
        TargetTable =
         { Name = TableName "UidefaultPinConfigurationsUidefaultPinDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UidefaultPinConfigurationId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "UidefaultPinDetailId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
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
        Destination = EntityName "UidefaultPinConfigurationsUidefaultPinDetail"
        KeyType = Guid }] }-DefaultGpioPinType-loader",
                            async ids => 
                            {
                                var data = await dbContext.DefaultGpioPinTypes
                                    .Where(x => x.DefaultGpioPinType != null && ids.Contains((short)x.DefaultGpioPinType))
                                    .Select(x => new
                                    {
                                        Key = (short)x.DefaultGpioPinType!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.DefaultGpioPinType);
                });
            
			
                Field<UidefaultPinConfigurationsUidefaultPinDetailGraphType, UidefaultPinConfigurationsUidefaultPinDetail>("UidefaultPinConfigurationsUidefaultPinDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UidefaultPinConfigurationsUidefaultPinDetailGraphType>>(
                            "{ Name = EntityName "UidefaultPinDetail"
  CorrespondingTable =
   Regular
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
  Fields =
   [{ Name = "UidefaultPinDetailId"
      Type = Id Guid
      IsNullable = false }; { Name = "VirtualPinNumber"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "High"
                                                      Type = Primitive Bool
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "DefaultGpioPinType"
        TargetTable =
         { Name = TableName "DefaultGpioPinType"
           Properties =
            [PrimaryKey { Type = Short
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Description"
                                                            IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsOutput"
                         IsNullable = false };
             Navigation { Type = TableName "DefaultPinDetail"
                          Name = "DefaultPinDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UidefaultPinDetail"
                          Name = "UidefaultPinDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "DefaultGpioPinType"
        IsNullable = false
        KeyType = Short };
    OneToMany
      { Name = RelationName "UidefaultPinConfigurationsUidefaultPinDetail"
        TargetTable =
         { Name = TableName "UidefaultPinConfigurationsUidefaultPinDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UidefaultPinConfigurationId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "UidefaultPinDetailId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
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
        Destination = EntityName "UidefaultPinConfigurationsUidefaultPinDetail"
        KeyType = Guid }] }-UidefaultPinConfigurationsUidefaultPinDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.UidefaultPinConfigurationsUidefaultPinDetails
                                    .Where(x => x.UidefaultPinConfigurationsUidefaultPinDetail != null && ids.Contains((Guid)x.UidefaultPinConfigurationsUidefaultPinDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UidefaultPinConfigurationsUidefaultPinDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.UidefaultPinConfigurationsUidefaultPinDetails);
                    });
            
        }
    }
}
            
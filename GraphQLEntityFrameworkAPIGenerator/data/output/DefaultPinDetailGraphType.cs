
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
    public partial class DefaultPinDetailGraphType : ObjectGraphType<DefaultPinDetail>
    {
        public DefaultPinDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.DefaultPinDetailId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.VirtualPinNumber, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.High, type: typeof(BoolGraphType), nullable: False);
            
                Field<DefaultPinConfigurationsDefaultPinDetailGraphType, DefaultPinConfigurationsDefaultPinDetail>("DefaultPinConfigurationsDefaultPinDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<DefaultPinConfigurationsDefaultPinDetailGraphType>>(
                            "{ Name = EntityName "DefaultPinDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "DefaultPinDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "DefaultPinDetailId"
                      IsNullable = false };
         Primitive { Type = Byte
                     Name = "VirtualPinNumber"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "High"
                                                       IsNullable = false };
         ForeignKey { Type = Short
                      Name = "GpioPinTypeId"
                      IsNullable = false };
         Navigation
           { Type = TableName "DefaultPinConfigurationsDefaultPinDetail"
             Name = "DefaultPinConfigurationsDefaultPinDetails"
             IsNullable = false
             IsCollection = true };
         Navigation { Type = TableName "DefaultGpioPinType"
                      Name = "GpioPinType"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "DefaultPinDetailId"
      Type = Id Guid
      IsNullable = false }; { Name = "VirtualPinNumber"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "High"
                                                      Type = Primitive Bool
                                                      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "DefaultPinConfigurationsDefaultPinDetail"
        TargetTable =
         { Name = TableName "DefaultPinConfigurationsDefaultPinDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "DefaultPinConfigurationId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "DefaultPinDetailId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "DefaultPinConfiguration"
                          Name = "DefaultPinConfiguration"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "DefaultPinDetail"
                          Name = "DefaultPinDetail"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "DefaultPinConfigurationsDefaultPinDetail"
        KeyType = Guid };
    SingleManyToOne
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
        KeyType = Short }] }-DefaultPinConfigurationsDefaultPinDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.DefaultPinConfigurationsDefaultPinDetails
                                    .Where(x => x.DefaultPinConfigurationsDefaultPinDetail != null && ids.Contains((Guid)x.DefaultPinConfigurationsDefaultPinDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.DefaultPinConfigurationsDefaultPinDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.DefaultPinConfigurationsDefaultPinDetails);
                    });
            
			
                Field<DefaultGpioPinTypeGraphType, DefaultGpioPinType>("DefaultGpioPinTypes")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<short, DefaultGpioPinTypeGraphType>(
                            "{ Name = EntityName "DefaultPinDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "DefaultPinDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "DefaultPinDetailId"
                      IsNullable = false };
         Primitive { Type = Byte
                     Name = "VirtualPinNumber"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "High"
                                                       IsNullable = false };
         ForeignKey { Type = Short
                      Name = "GpioPinTypeId"
                      IsNullable = false };
         Navigation
           { Type = TableName "DefaultPinConfigurationsDefaultPinDetail"
             Name = "DefaultPinConfigurationsDefaultPinDetails"
             IsNullable = false
             IsCollection = true };
         Navigation { Type = TableName "DefaultGpioPinType"
                      Name = "GpioPinType"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "DefaultPinDetailId"
      Type = Id Guid
      IsNullable = false }; { Name = "VirtualPinNumber"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "High"
                                                      Type = Primitive Bool
                                                      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "DefaultPinConfigurationsDefaultPinDetail"
        TargetTable =
         { Name = TableName "DefaultPinConfigurationsDefaultPinDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "DefaultPinConfigurationId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "DefaultPinDetailId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "DefaultPinConfiguration"
                          Name = "DefaultPinConfiguration"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "DefaultPinDetail"
                          Name = "DefaultPinDetail"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "DefaultPinConfigurationsDefaultPinDetail"
        KeyType = Guid };
    SingleManyToOne
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
        KeyType = Short }] }-DefaultGpioPinType-loader",
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
            
        }
    }
}
            

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
    public partial class UisreventDetailGraphType : ObjectGraphType<UisreventDetail>
    {
        public UisreventDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UisreventDetailId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.SrinputPos, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Compartment, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Srevent, type: typeof(ByteGraphType), nullable: False);
            
                Field<UigenericInputReadTypeGraphType, UigenericInputReadType>("UigenericInputReadTypes")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, UigenericInputReadTypeGraphType>(
                            "{ Name = EntityName "UisreventDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "UisreventDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UisreventDetailId"
                      IsNullable = false }; ForeignKey { Type = Byte
                                                         Name = "SrinputId"
                                                         IsNullable = false };
         Primitive { Type = Byte
                     Name = "SrinputPos"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Compartment"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "Srevent"
                     IsNullable = false }; ForeignKey { Type = Guid
                                                        Name = "SreventPrmId"
                                                        IsNullable = true };
         Navigation { Type = TableName "UigenericInputReadType"
                      Name = "Srinput"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "UisreventConfigurationsUisreventDetail"
                      Name = "UisreventConfigurationsUisreventDetails"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "UisreventDetailId"
      Type = Id Guid
      IsNullable = false }; { Name = "SrinputPos"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Compartment"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Srevent"
      Type = Primitive Byte
      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "UigenericInputReadType"
        TargetTable =
         { Name = TableName "UigenericInputReadType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "UireadTypeId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "UireadTypeDsc"
                         IsNullable = false };
             Navigation { Type = TableName "UiclassBeventDetail"
                          Name = "UiclassBeventDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Uiinput"
                          Name = "Uiinputs"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UisreventDetail"
                          Name = "UisreventDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "UigenericInputReadType"
        IsNullable = false
        KeyType = Byte };
    OneToMany
      { Name = RelationName "UisreventConfigurationsUisreventDetail"
        TargetTable =
         { Name = TableName "UisreventConfigurationsUisreventDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UisreventConfigurationId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "UisreventDetailId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
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
        Destination = EntityName "UisreventConfigurationsUisreventDetail"
        KeyType = Guid }] }-UigenericInputReadType-loader",
                            async ids => 
                            {
                                var data = await dbContext.UigenericInputReadTypes
                                    .Where(x => x.UigenericInputReadType != null && ids.Contains((byte)x.UigenericInputReadType))
                                    .Select(x => new
                                    {
                                        Key = (byte)x.UigenericInputReadType!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.UigenericInputReadType);
                });
            
			
                Field<UisreventConfigurationsUisreventDetailGraphType, UisreventConfigurationsUisreventDetail>("UisreventConfigurationsUisreventDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UisreventConfigurationsUisreventDetailGraphType>>(
                            "{ Name = EntityName "UisreventDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "UisreventDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UisreventDetailId"
                      IsNullable = false }; ForeignKey { Type = Byte
                                                         Name = "SrinputId"
                                                         IsNullable = false };
         Primitive { Type = Byte
                     Name = "SrinputPos"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Compartment"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "Srevent"
                     IsNullable = false }; ForeignKey { Type = Guid
                                                        Name = "SreventPrmId"
                                                        IsNullable = true };
         Navigation { Type = TableName "UigenericInputReadType"
                      Name = "Srinput"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "UisreventConfigurationsUisreventDetail"
                      Name = "UisreventConfigurationsUisreventDetails"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "UisreventDetailId"
      Type = Id Guid
      IsNullable = false }; { Name = "SrinputPos"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Compartment"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Srevent"
      Type = Primitive Byte
      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "UigenericInputReadType"
        TargetTable =
         { Name = TableName "UigenericInputReadType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "UireadTypeId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "UireadTypeDsc"
                         IsNullable = false };
             Navigation { Type = TableName "UiclassBeventDetail"
                          Name = "UiclassBeventDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Uiinput"
                          Name = "Uiinputs"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UisreventDetail"
                          Name = "UisreventDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "UigenericInputReadType"
        IsNullable = false
        KeyType = Byte };
    OneToMany
      { Name = RelationName "UisreventConfigurationsUisreventDetail"
        TargetTable =
         { Name = TableName "UisreventConfigurationsUisreventDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UisreventConfigurationId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "UisreventDetailId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
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
        Destination = EntityName "UisreventConfigurationsUisreventDetail"
        KeyType = Guid }] }-UisreventConfigurationsUisreventDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.UisreventConfigurationsUisreventDetails
                                    .Where(x => x.UisreventConfigurationsUisreventDetail != null && ids.Contains((Guid)x.UisreventConfigurationsUisreventDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UisreventConfigurationsUisreventDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.UisreventConfigurationsUisreventDetails);
                    });
            
        }
    }
}
            
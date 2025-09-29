
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
    public partial class UigenericInputReadTypeGraphType : ObjectGraphType<UigenericInputReadType>
    {
        public UigenericInputReadTypeGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UireadTypeId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.UireadTypeDsc, type: typeof(StringGraphType), nullable: False);
            
                Field<UiclassBeventDetailGraphType, UiclassBeventDetail>("UiclassBeventDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UiclassBeventDetailGraphType>>(
                            "{ Name = EntityName "UigenericInputReadType"
  CorrespondingTable =
   Regular
     { Name = TableName "UigenericInputReadType"
       Properties =
        [PrimaryKey { Type = Byte
                      Name = "UireadTypeId"
                      IsNullable = false }; Primitive { Type = String
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
  Fields = [{ Name = "UireadTypeId"
              Type = Id Byte
              IsNullable = false }; { Name = "UireadTypeDsc"
                                      Type = Primitive String
                                      IsNullable = false }]
  Relations =
   [OneToMany
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
        KeyType = Guid };
    OneToMany
      { Name = RelationName "Uiinput"
        TargetTable =
         { Name = TableName "Uiinput"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "UiinputId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "UiinputDsc"
                                                            IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "GireadTypeId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "LlireadTypeId"
                          IsNullable = false }; Primitive { Type = Bool
                                                            Name = "NeedParams"
                                                            IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsSafetyRelevant"
                         IsNullable = false };
             Navigation { Type = TableName "UigenericInputReadType"
                          Name = "GireadType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ReadType"
                          Name = "LlireadType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UigenericInputDetail"
                          Name = "UigenericInputDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadTypes"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "Uiinput"
        KeyType = Byte };
    OneToMany
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
                            });

                        return loader.LoadAsync(context.Source.UiclassBeventDetails);
                    });
            
			
                Field<UiinputGraphType, Uiinput>("Uiinputs")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, IEnumerable<UiinputGraphType>>(
                            "{ Name = EntityName "UigenericInputReadType"
  CorrespondingTable =
   Regular
     { Name = TableName "UigenericInputReadType"
       Properties =
        [PrimaryKey { Type = Byte
                      Name = "UireadTypeId"
                      IsNullable = false }; Primitive { Type = String
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
  Fields = [{ Name = "UireadTypeId"
              Type = Id Byte
              IsNullable = false }; { Name = "UireadTypeDsc"
                                      Type = Primitive String
                                      IsNullable = false }]
  Relations =
   [OneToMany
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
        KeyType = Guid };
    OneToMany
      { Name = RelationName "Uiinput"
        TargetTable =
         { Name = TableName "Uiinput"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "UiinputId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "UiinputDsc"
                                                            IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "GireadTypeId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "LlireadTypeId"
                          IsNullable = false }; Primitive { Type = Bool
                                                            Name = "NeedParams"
                                                            IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsSafetyRelevant"
                         IsNullable = false };
             Navigation { Type = TableName "UigenericInputReadType"
                          Name = "GireadType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ReadType"
                          Name = "LlireadType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UigenericInputDetail"
                          Name = "UigenericInputDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadTypes"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "Uiinput"
        KeyType = Byte };
    OneToMany
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
        KeyType = Guid }] }-Uiinput-loader",
                            async ids => 
                            {
                                var data = await dbContext.Uiinputs
                                    .Where(x => x.Uiinput != null && ids.Contains((byte)x.Uiinput))
                                    .Select(x => new
                                    {
                                        Key = (byte)x.Uiinput!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.Uiinputs);
                    });
            
			
                Field<UisreventDetailGraphType, UisreventDetail>("UisreventDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UisreventDetailGraphType>>(
                            "{ Name = EntityName "UigenericInputReadType"
  CorrespondingTable =
   Regular
     { Name = TableName "UigenericInputReadType"
       Properties =
        [PrimaryKey { Type = Byte
                      Name = "UireadTypeId"
                      IsNullable = false }; Primitive { Type = String
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
  Fields = [{ Name = "UireadTypeId"
              Type = Id Byte
              IsNullable = false }; { Name = "UireadTypeDsc"
                                      Type = Primitive String
                                      IsNullable = false }]
  Relations =
   [OneToMany
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
        KeyType = Guid };
    OneToMany
      { Name = RelationName "Uiinput"
        TargetTable =
         { Name = TableName "Uiinput"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "UiinputId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "UiinputDsc"
                                                            IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "GireadTypeId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "LlireadTypeId"
                          IsNullable = false }; Primitive { Type = Bool
                                                            Name = "NeedParams"
                                                            IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsSafetyRelevant"
                         IsNullable = false };
             Navigation { Type = TableName "UigenericInputReadType"
                          Name = "GireadType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ReadType"
                          Name = "LlireadType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UigenericInputDetail"
                          Name = "UigenericInputDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadTypes"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "Uiinput"
        KeyType = Byte };
    OneToMany
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
                            });

                        return loader.LoadAsync(context.Source.UisreventDetails);
                    });
            
        }
    }
}
            
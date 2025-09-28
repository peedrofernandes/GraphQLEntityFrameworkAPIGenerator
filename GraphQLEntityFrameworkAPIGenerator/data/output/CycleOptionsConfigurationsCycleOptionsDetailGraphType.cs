
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
    public partial class CycleOptionsConfigurationsCycleOptionsDetailGraphType : ObjectGraphType<CycleOptionsConfigurationsCycleOptionsDetail>
    {
        public CycleOptionsConfigurationsCycleOptionsDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.CycleOptionsConfigurationsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.CycleOptionsDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<CycleOptionsConfigurationGraphType, CycleOptionsConfiguration>("CycleOptionsConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, CycleOptionsConfigurationGraphType>(
                            "{ Name = EntityName "CycleOptionsConfigurationsCycleOptionsDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "CycleOptionsConfigurationsCycleOptionsDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "CycleOptionsConfigurationsId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "CycleOptionsDetailsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "CycleOptionsConfiguration"
                      Name = "CycleOptionsConfigurations"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "CycleOptionsDetail"
                      Name = "CycleOptionsDetails"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "CycleOptionsConfigurationsId"
      Type = Id Guid
      IsNullable = false }; { Name = "CycleOptionsDetailsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "CycleOptionsConfiguration"
        TargetTable =
         { Name = TableName "CycleOptionsConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CycleOptionsConfigurationsId"
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
             Navigation
               { Type = TableName "CycleMappingCycleOptionsConfiguration"
                 Name = "CycleMappingCycleOptionsConfigurations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "CycleOptionsConfigurationsCycleOptionsDetail"
                 Name = "CycleOptionsConfigurationsCycleOptionsDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "CycleOptionsConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "CycleOptionsDetail"
        TargetTable =
         { Name = TableName "CycleOptionsDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CycleOptionsDetailsId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Input1"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "InputValue1"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Input2"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "InputValue2"
                         IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "OptionTypeId"
                          IsNullable = false }; ForeignKey { Type = Guid
                                                             Name = "OptionId"
                                                             IsNullable = true };
             Primitive { Type = Byte
                         Name = "NumberOfModifiers"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Grouping1"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "Grouping2"
                         IsNullable = false };
             Navigation
               { Type = TableName "CycleOptionsConfigurationsCycleOptionsDetail"
                 Name = "CycleOptionsConfigurationsCycleOptionsDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "CycleOptionsDetail"
        IsNullable = false
        KeyType = Guid }] }-CycleOptionsConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.CycleOptionsConfigurations
                                    .Where(x => x.CycleOptionsConfiguration != null && ids.Contains((Guid)x.CycleOptionsConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.CycleOptionsConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.CycleOptionsConfiguration);
                });
            
			
                Field<CycleOptionsDetailGraphType, CycleOptionsDetail>("CycleOptionsDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, CycleOptionsDetailGraphType>(
                            "{ Name = EntityName "CycleOptionsConfigurationsCycleOptionsDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "CycleOptionsConfigurationsCycleOptionsDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "CycleOptionsConfigurationsId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "CycleOptionsDetailsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "CycleOptionsConfiguration"
                      Name = "CycleOptionsConfigurations"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "CycleOptionsDetail"
                      Name = "CycleOptionsDetails"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "CycleOptionsConfigurationsId"
      Type = Id Guid
      IsNullable = false }; { Name = "CycleOptionsDetailsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "CycleOptionsConfiguration"
        TargetTable =
         { Name = TableName "CycleOptionsConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CycleOptionsConfigurationsId"
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
             Navigation
               { Type = TableName "CycleMappingCycleOptionsConfiguration"
                 Name = "CycleMappingCycleOptionsConfigurations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "CycleOptionsConfigurationsCycleOptionsDetail"
                 Name = "CycleOptionsConfigurationsCycleOptionsDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "CycleOptionsConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "CycleOptionsDetail"
        TargetTable =
         { Name = TableName "CycleOptionsDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CycleOptionsDetailsId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Input1"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "InputValue1"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Input2"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "InputValue2"
                         IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "OptionTypeId"
                          IsNullable = false }; ForeignKey { Type = Guid
                                                             Name = "OptionId"
                                                             IsNullable = true };
             Primitive { Type = Byte
                         Name = "NumberOfModifiers"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Grouping1"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "Grouping2"
                         IsNullable = false };
             Navigation
               { Type = TableName "CycleOptionsConfigurationsCycleOptionsDetail"
                 Name = "CycleOptionsConfigurationsCycleOptionsDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "CycleOptionsDetail"
        IsNullable = false
        KeyType = Guid }] }-CycleOptionsDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.CycleOptionsDetails
                                    .Where(x => x.CycleOptionsDetail != null && ids.Contains((Guid)x.CycleOptionsDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.CycleOptionsDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.CycleOptionsDetail);
                });
            
        }
    }
}
            
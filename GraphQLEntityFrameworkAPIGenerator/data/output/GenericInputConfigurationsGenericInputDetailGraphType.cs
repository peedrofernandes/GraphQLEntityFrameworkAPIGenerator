
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
    public partial class GenericInputConfigurationsGenericInputDetailGraphType : ObjectGraphType<GenericInputConfigurationsGenericInputDetail>
    {
        public GenericInputConfigurationsGenericInputDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.GenericInputConfigurationId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.GenericInputDetailId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<GenericInputConfigurationGraphType, GenericInputConfiguration>("GenericInputConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, GenericInputConfigurationGraphType>(
                            "{ Name = EntityName "GenericInputConfigurationsGenericInputDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "GenericInputConfigurationsGenericInputDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "GenericInputConfigurationId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "GenericInputDetailId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "GenericInputConfiguration"
                      Name = "GenericInputConfiguration"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "GenericInputDetail"
                      Name = "GenericInputDetail"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "GenericInputConfigurationId"
      Type = Id Guid
      IsNullable = false }; { Name = "GenericInputDetailId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "GenericInputConfiguration"
        TargetTable =
         { Name = TableName "GenericInputConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "GenericInputConfigurationId"
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
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type = TableName "GenericInputConfigurationsGenericInputDetail"
                 Name = "GenericInputConfigurationsGenericInputDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "GenericInputConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "GenericInputDetail"
        TargetTable =
         { Name = TableName "GenericInputDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "GenericInputDetailId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "InputId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "ReadTypeId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "ReadTypePos"
                                                            IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "ParametersId"
                          IsNullable = true };
             Navigation
               { Type = TableName "GenericInputConfigurationsGenericInputDetail"
                 Name = "GenericInputConfigurationsGenericInputDetails"
                 IsNullable = false
                 IsCollection = true }; Navigation { Type = TableName "Input"
                                                     Name = "Input"
                                                     IsNullable = false
                                                     IsCollection = false };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadType"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "GenericInputDetail"
        IsNullable = false
        KeyType = Guid }] }-GenericInputConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.GenericInputConfigurations
                                    .Where(x => x.GenericInputConfiguration != null && ids.Contains((Guid)x.GenericInputConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.GenericInputConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.GenericInputConfiguration);
                });
            
			
                Field<GenericInputDetailGraphType, GenericInputDetail>("GenericInputDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, GenericInputDetailGraphType>(
                            "{ Name = EntityName "GenericInputConfigurationsGenericInputDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "GenericInputConfigurationsGenericInputDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "GenericInputConfigurationId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "GenericInputDetailId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "GenericInputConfiguration"
                      Name = "GenericInputConfiguration"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "GenericInputDetail"
                      Name = "GenericInputDetail"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "GenericInputConfigurationId"
      Type = Id Guid
      IsNullable = false }; { Name = "GenericInputDetailId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "GenericInputConfiguration"
        TargetTable =
         { Name = TableName "GenericInputConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "GenericInputConfigurationId"
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
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type = TableName "GenericInputConfigurationsGenericInputDetail"
                 Name = "GenericInputConfigurationsGenericInputDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "GenericInputConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "GenericInputDetail"
        TargetTable =
         { Name = TableName "GenericInputDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "GenericInputDetailId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "InputId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "ReadTypeId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "ReadTypePos"
                                                            IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "ParametersId"
                          IsNullable = true };
             Navigation
               { Type = TableName "GenericInputConfigurationsGenericInputDetail"
                 Name = "GenericInputConfigurationsGenericInputDetails"
                 IsNullable = false
                 IsCollection = true }; Navigation { Type = TableName "Input"
                                                     Name = "Input"
                                                     IsNullable = false
                                                     IsCollection = false };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadType"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "GenericInputDetail"
        IsNullable = false
        KeyType = Guid }] }-GenericInputDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.GenericInputDetails
                                    .Where(x => x.GenericInputDetail != null && ids.Contains((Guid)x.GenericInputDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.GenericInputDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.GenericInputDetail);
                });
            
        }
    }
}
            
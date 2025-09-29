
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
    public partial class CycleOptionsDetailGraphType : ObjectGraphType<CycleOptionsDetail>
    {
        public CycleOptionsDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.CycleOptionsDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Input1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputValue1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Input2, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputValue2, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.NumberOfModifiers, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Grouping1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Grouping2, type: typeof(ByteGraphType), nullable: False);
            
                Field<CycleOptionsConfigurationsCycleOptionsDetailGraphType, CycleOptionsConfigurationsCycleOptionsDetail>("CycleOptionsConfigurationsCycleOptionsDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CycleOptionsConfigurationsCycleOptionsDetailGraphType>>(
                            "{ Name = EntityName "CycleOptionsDetail"
  CorrespondingTable =
   Regular
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
                     IsNullable = false }; ForeignKey { Type = Byte
                                                        Name = "OptionTypeId"
                                                        IsNullable = false };
         ForeignKey { Type = Guid
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
  Fields =
   [{ Name = "CycleOptionsDetailsId"
      Type = Id Guid
      IsNullable = false }; { Name = "Input1"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "InputValue1"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Input2"
      Type = Primitive Byte
      IsNullable = false }; { Name = "InputValue2"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "NumberOfModifiers"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Grouping1"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Grouping2"
                              Type = Primitive Byte
                              IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "CycleOptionsConfigurationsCycleOptionsDetail"
        TargetTable =
         { Name = TableName "CycleOptionsConfigurationsCycleOptionsDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CycleOptionsConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "CycleOptionsDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
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
        Destination = EntityName "CycleOptionsConfigurationsCycleOptionsDetail"
        KeyType = Guid }] }-CycleOptionsConfigurationsCycleOptionsDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.CycleOptionsConfigurationsCycleOptionsDetails
                                    .Where(x => x.CycleOptionsConfigurationsCycleOptionsDetail != null && ids.Contains((Guid)x.CycleOptionsConfigurationsCycleOptionsDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.CycleOptionsConfigurationsCycleOptionsDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.CycleOptionsConfigurationsCycleOptionsDetails);
                    });
            
        }
    }
}
            

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
    public partial class FunctionLabelGraphType : ObjectGraphType<FunctionLabel>
    {
        public FunctionLabelGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.FunctionLabelId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.FunctionLabel1, type: typeof(StringGraphType), nullable: False);
            
                Field<UifunctionConfigurationsUifunctionDetailGraphType, UifunctionConfigurationsUifunctionDetail>("UifunctionConfigurationsUifunctionDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UifunctionConfigurationsUifunctionDetailGraphType>>(
                            "{ Name = EntityName "FunctionLabel"
  CorrespondingTable =
   Regular
     { Name = TableName "FunctionLabel"
       Properties =
        [PrimaryKey { Type = Byte
                      Name = "FunctionLabelId"
                      IsNullable = false }; Primitive { Type = String
                                                        Name = "FunctionLabel1"
                                                        IsNullable = false };
         Navigation
           { Type = TableName "UifunctionConfigurationsUifunctionDetail"
             Name = "UifunctionConfigurationsUifunctionDetails"
             IsNullable = false
             IsCollection = true }] }
  Fields = [{ Name = "FunctionLabelId"
              Type = Id Byte
              IsNullable = false }; { Name = "FunctionLabel1"
                                      Type = Primitive String
                                      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "UifunctionConfigurationsUifunctionDetail"
        TargetTable =
         { Name = TableName "UifunctionConfigurationsUifunctionDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UifunctionConfigurationId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "UifunctionDetailId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "GireadTypeId"
                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "GireadTypePosition"
                         IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "UiregulationTableId"
                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "FunctionLabel"
                         IsNullable = true }; Primitive { Type = Bool
                                                          Name = "Compulsory"
                                                          IsNullable = false };
             Primitive { Type = Bool
                         Name = "Monitored"
                         IsNullable = false };
             Navigation { Type = TableName "FunctionLabel"
                          Name = "FunctionLabelNavigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UifunctionConfiguration"
                          Name = "UifunctionConfiguration"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UifunctionDetail"
                          Name = "UifunctionDetail"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UiregulationTable"
                          Name = "UiregulationTable"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "UifunctionConfigurationsUifunctionDetail"
        KeyType = Guid }] }-UifunctionConfigurationsUifunctionDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.UifunctionConfigurationsUifunctionDetails
                                    .Where(x => x.UifunctionConfigurationsUifunctionDetail != null && ids.Contains((Guid)x.UifunctionConfigurationsUifunctionDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UifunctionConfigurationsUifunctionDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.UifunctionConfigurationsUifunctionDetails);
                    });
            
        }
    }
}
            
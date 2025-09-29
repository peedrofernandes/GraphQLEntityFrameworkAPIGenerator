
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
    public partial class DebounceMethodPrescalarGraphType : ObjectGraphType<DebounceMethodPrescalar>
    {
        public DebounceMethodPrescalarGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.DebounceMethodPrescalarId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.DebounceMethodPrescalarDescription, type: typeof(StringGraphType), nullable: False);
            
                Field<DebounceMethodParameterGraphType, DebounceMethodParameter>("DebounceMethodParameters")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<DebounceMethodParameterGraphType>>(
                            "{ Name = EntityName "DebounceMethodPrescalar"
  CorrespondingTable =
   Regular
     { Name = TableName "DebounceMethodPrescalar"
       Properties =
        [PrimaryKey { Type = Byte
                      Name = "DebounceMethodPrescalarId"
                      IsNullable = false };
         Primitive { Type = String
                     Name = "DebounceMethodPrescalarDescription"
                     IsNullable = false };
         Navigation { Type = TableName "DebounceMethodParameter"
                      Name = "DebounceMethodParameterFaultPrescalars"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "DebounceMethodParameter"
                      Name = "DebounceMethodParameterPrefaultPrescalars"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "DebounceMethodParameter"
                      Name = "DebounceMethodParameterRemovedFaultPrescalars"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "DebounceMethodParameter"
                      Name = "DebounceMethodParameterRemovedPrefaultPrescalars"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "DebounceMethodPrescalarId"
      Type = Id Byte
      IsNullable = false }; { Name = "DebounceMethodPrescalarDescription"
                              Type = Primitive String
                              IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "DebounceMethodParameter"
        TargetTable =
         { Name = TableName "DebounceMethodParameter"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "DebounceMethodParametersId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "PrefaultDebounceMethodId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "PrefaultPrescalarId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "PrefaultDelay"
                         IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "FaultDebounceMethodId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "FaultPrescalarId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "FaultDelay"
                                                            IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "RemovedPrefaultPrescalarId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "RemovedPrefaultDelay"
                         IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "RemovedFaultPrescalarId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "RemovedFaultDelay"
                         IsNullable = false };
             Navigation { Type = TableName "DebounceMethod"
                          Name = "FaultDebounceMethod"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "FaultDetail"
                          Name = "FaultDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "DebounceMethodPrescalar"
                          Name = "FaultPrescalar"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "DebounceMethod"
                          Name = "PrefaultDebounceMethod"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "DebounceMethodPrescalar"
                          Name = "PrefaultPrescalar"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "DebounceMethodPrescalar"
                          Name = "RemovedFaultPrescalar"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "DebounceMethodPrescalar"
                          Name = "RemovedPrefaultPrescalar"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "DebounceMethodParameter"
        KeyType = Guid }] }-DebounceMethodParameter-loader",
                            async ids => 
                            {
                                var data = await dbContext.DebounceMethodParameters
                                    .Where(x => x.DebounceMethodParameter != null && ids.Contains((Guid)x.DebounceMethodParameter))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.DebounceMethodParameter!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.DebounceMethodParameters);
                    });
            
        }
    }
}
            
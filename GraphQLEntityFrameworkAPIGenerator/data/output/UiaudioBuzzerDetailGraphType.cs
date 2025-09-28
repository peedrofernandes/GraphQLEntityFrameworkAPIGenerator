
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
    public partial class UiaudioBuzzerDetailGraphType : ObjectGraphType<UiaudioBuzzerDetail>
    {
        public UiaudioBuzzerDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.PrmUiaudioBuzzerDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Frequency, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.TimeOn, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.TimeOff, type: typeof(ShortGraphType), nullable: False);
            
                Field<UiaudioBuzzerUiaudioBuzzerDetailGraphType, UiaudioBuzzerUiaudioBuzzerDetail>("UiaudioBuzzerUiaudioBuzzerDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UiaudioBuzzerUiaudioBuzzerDetailGraphType>>(
                            "{ Name = EntityName "UiaudioBuzzerDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "UiaudioBuzzerDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "PrmUiaudioBuzzerDetailsId"
                      IsNullable = false }; Primitive { Type = Short
                                                        Name = "Frequency"
                                                        IsNullable = false };
         Primitive { Type = Short
                     Name = "TimeOn"
                     IsNullable = false }; Primitive { Type = Short
                                                       Name = "TimeOff"
                                                       IsNullable = false };
         Navigation { Type = TableName "UiaudioBuzzerUiaudioBuzzerDetail"
                      Name = "UiaudioBuzzerUiaudioBuzzerDetails"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "PrmUiaudioBuzzerDetailsId"
      Type = Id Guid
      IsNullable = false }; { Name = "Frequency"
                              Type = Primitive Short
                              IsNullable = false }; { Name = "TimeOn"
                                                      Type = Primitive Short
                                                      IsNullable = false };
    { Name = "TimeOff"
      Type = Primitive Short
      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "UiaudioBuzzerUiaudioBuzzerDetail"
        TargetTable =
         { Name = TableName "UiaudioBuzzerUiaudioBuzzerDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "PrmUiaudioBuzzerDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "PrmUiaudioBuzzer"
                          Name = "IdNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UiaudioBuzzerDetail"
                          Name = "PrmUiaudioBuzzerDetails"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "UiaudioBuzzerUiaudioBuzzerDetail"
        KeyType = Guid }] }-UiaudioBuzzerUiaudioBuzzerDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.UiaudioBuzzerUiaudioBuzzerDetails
                                    .Where(x => x.UiaudioBuzzerUiaudioBuzzerDetail != null && ids.Contains((Guid)x.UiaudioBuzzerUiaudioBuzzerDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UiaudioBuzzerUiaudioBuzzerDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.UiaudioBuzzerUiaudioBuzzerDetails);
                    });
            
        }
    }
}
            
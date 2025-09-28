
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
    public partial class PilotMultiSequenceDetailGraphType : ObjectGraphType<PilotMultiSequenceDetail>
    {
        public PilotMultiSequenceDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.DetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.NumberOfSteps, type: typeof(ByteGraphType), nullable: False);
            
                Field<PilotMultiSequenceConfigDetailGraphType, PilotMultiSequenceConfigDetail>("PilotMultiSequenceConfigDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PilotMultiSequenceConfigDetailGraphType>>(
                            "{ Name = EntityName "PilotMultiSequenceDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "PilotMultiSequenceDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "DetailsId"
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
                     IsNullable = false }; Primitive { Type = Guid
                                                       Name = "RevisionGroup"
                                                       IsNullable = false };
         Primitive { Type = Int
                     Name = "Revision"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "TableTarget"
                                                       IsNullable = false };
         Primitive { Type = String
                     Name = "Notes"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "NumberOfSteps"
                                                      IsNullable = false };
         Navigation { Type = TableName "PilotMultiSequenceConfigDetail"
                      Name = "PilotMultiSequenceConfigDetails"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "PilotMultiSequenceDetailsStep"
                      Name = "PilotMultiSequenceDetailsSteps"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "DetailsId"
      Type = Id Guid
      IsNullable = false }; { Name = "Description"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Status"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Owner"
      Type = Primitive String
      IsNullable = false }; { Name = "Timestamp"
                              Type = Primitive DateTime
                              IsNullable = false }; { Name = "RevisionGroup"
                                                      Type = Primitive Guid
                                                      IsNullable = false };
    { Name = "Revision"
      Type = Primitive Int
      IsNullable = false }; { Name = "TableTarget"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Notes"
                                                      Type = Primitive String
                                                      IsNullable = true };
    { Name = "NumberOfSteps"
      Type = Primitive Byte
      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "PilotMultiSequenceConfigDetail"
        TargetTable =
         { Name = TableName "PilotMultiSequenceConfigDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "ConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "DetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "PilotMultiSequenceConfig"
                          Name = "Config"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "PilotMultiSequenceDetail"
                          Name = "Details"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "PilotMultiSequenceConfigDetail"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "PilotMultiSequenceDetailsStep"
        TargetTable =
         { Name = TableName "PilotMultiSequenceDetailsStep"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "DetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "PilotMultiSequenceDetail"
                          Name = "Details"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "PilotMultiSequenceStep"
                          Name = "IdNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "PilotMultiSequenceDetailsStep"
        KeyType = Guid }] }-PilotMultiSequenceConfigDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.PilotMultiSequenceConfigDetails
                                    .Where(x => x.PilotMultiSequenceConfigDetail != null && ids.Contains((Guid)x.PilotMultiSequenceConfigDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PilotMultiSequenceConfigDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.PilotMultiSequenceConfigDetails);
                    });
            
			
                Field<PilotMultiSequenceDetailsStepGraphType, PilotMultiSequenceDetailsStep>("PilotMultiSequenceDetailsSteps")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PilotMultiSequenceDetailsStepGraphType>>(
                            "{ Name = EntityName "PilotMultiSequenceDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "PilotMultiSequenceDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "DetailsId"
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
                     IsNullable = false }; Primitive { Type = Guid
                                                       Name = "RevisionGroup"
                                                       IsNullable = false };
         Primitive { Type = Int
                     Name = "Revision"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "TableTarget"
                                                       IsNullable = false };
         Primitive { Type = String
                     Name = "Notes"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "NumberOfSteps"
                                                      IsNullable = false };
         Navigation { Type = TableName "PilotMultiSequenceConfigDetail"
                      Name = "PilotMultiSequenceConfigDetails"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "PilotMultiSequenceDetailsStep"
                      Name = "PilotMultiSequenceDetailsSteps"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "DetailsId"
      Type = Id Guid
      IsNullable = false }; { Name = "Description"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Status"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Owner"
      Type = Primitive String
      IsNullable = false }; { Name = "Timestamp"
                              Type = Primitive DateTime
                              IsNullable = false }; { Name = "RevisionGroup"
                                                      Type = Primitive Guid
                                                      IsNullable = false };
    { Name = "Revision"
      Type = Primitive Int
      IsNullable = false }; { Name = "TableTarget"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Notes"
                                                      Type = Primitive String
                                                      IsNullable = true };
    { Name = "NumberOfSteps"
      Type = Primitive Byte
      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "PilotMultiSequenceConfigDetail"
        TargetTable =
         { Name = TableName "PilotMultiSequenceConfigDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "ConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "DetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "PilotMultiSequenceConfig"
                          Name = "Config"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "PilotMultiSequenceDetail"
                          Name = "Details"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "PilotMultiSequenceConfigDetail"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "PilotMultiSequenceDetailsStep"
        TargetTable =
         { Name = TableName "PilotMultiSequenceDetailsStep"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "DetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "PilotMultiSequenceDetail"
                          Name = "Details"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "PilotMultiSequenceStep"
                          Name = "IdNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "PilotMultiSequenceDetailsStep"
        KeyType = Guid }] }-PilotMultiSequenceDetailsStep-loader",
                            async ids => 
                            {
                                var data = await dbContext.PilotMultiSequenceDetailsSteps
                                    .Where(x => x.PilotMultiSequenceDetailsStep != null && ids.Contains((Guid)x.PilotMultiSequenceDetailsStep))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PilotMultiSequenceDetailsStep!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.PilotMultiSequenceDetailsSteps);
                    });
            
        }
    }
}
            
﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mongo.DrivenAdapter.EntitiesMongo
{
	public class MarcaEntitie
	{
		[BsonId]
		[BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
		public string Id_Mongo { get; set; }
		public int Id { get; set; }

		public string Nombre_marca { get; set; }
	}
}
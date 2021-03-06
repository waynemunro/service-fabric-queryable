﻿using System;

namespace ServiceFabric.Extensions.Services.Queryable
{
	internal class Entity<TKey, TValue>
	{
		public Guid PartitionId { get; set; }

		public TKey Key { get; set; }

		public TValue Value { get; set; }

		public string Etag { get; set; }
	}
}
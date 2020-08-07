﻿using System.IO;
using System.Threading.Tasks;
using CoreWCF;

namespace ServiceContract
{
	[CoreWCF.ServiceContract]
	[System.ServiceModel.ServiceContract]
	public interface ISimplexService
	{
		[CoreWCF.OperationContract]
		[System.ServiceModel.OperationContract]
		void SimplexMethod(string msg);
	}
}
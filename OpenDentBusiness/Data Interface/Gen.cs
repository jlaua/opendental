﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Text;

namespace OpenDentBusiness{
	///<summary>A more secure version of "General", which passes specific method names to the server instead of just queries.  This also packages username and pass hash if remote.  User permissions will gradually be incorporated here.</summary>
	public class Gen {
		///<summary></summary>
		public static DataSet GetDS(MethodNameDS methodName,params object[] parameters) {
			return null;
		}

		///<summary></summary>
		public static DataTable GetTable(MethodNameTable methodName,params object[] parameters) {
			return null;
		}

		///<summary></summary>
		public static DataSet GetDS(MethodBase methodInfo, params object[] parameters) {
			string classMethod=methodInfo.DeclaringType.Name+"."+methodInfo.Name;
			if(RemotingClient.RemotingRole==RemotingRole.ClientWeb) {
				DtoGetDS dto=new DtoGetDS();
				dto.MethodNameDS=classMethod;
				dto.Parameters=parameters;
				dto.Credentials=new Credentials();
				dto.Credentials.Username=Security.CurUser.UserName;
				dto.Credentials.PassHash=Security.CurUser.Password;
				return RemotingClient.ProcessGetDS(dto);
			}
			else {
				return DataCore.GetDsByMethod(classMethod,parameters);
			}
		}

		///<summary>Usually, there is a just a single parameter for the query.</summary>
		public static DataTable GetTable(MethodBase methodInfo,string command) {
			string classMethod=methodInfo.DeclaringType.Name+"."+methodInfo.Name;
			if(RemotingClient.RemotingRole==RemotingRole.ClientWeb) {
				DtoGetTable dto=new DtoGetTable();
				dto.MethodNameTable=classMethod;
				//dto.Parameters=;
				dto.Credentials=new Credentials();
				dto.Credentials.Username=Security.CurUser.UserName;
				dto.Credentials.PassHash=Security.CurUser.Password;
				return RemotingClient.ProcessGetTable(dto);
			}
			else {
				DataConnection dcon=new DataConnection();
				return dcon.GetTable(command);
			}
		}

		/*
		///<summary>Usually, there is a just a single parameter for the query.</summary>
		public static DataTable GetTable(MethodBase methodInfo,params object[] parameters) {
			string classMethod=methodInfo.DeclaringType.Name+"."+methodInfo.Name;
			if(RemotingClient.RemotingRole==RemotingRole.ClientWeb) {
				DtoGetTable dto=new DtoGetTable();
				dto.MethodNameTable=classMethod;
				dto.Parameters=parameters;
				dto.Credentials=new Credentials();
				dto.Credentials.Username=Security.CurUser.UserName;
				dto.Credentials.PassHash=Security.CurUser.Password;
				return RemotingClient.ProcessGetTable(dto);
			}
			else {

				string className=classMethod.Split('.')[0];
				string methodName=classMethod.Split('.')[1];
				Type classType=Type.GetType("OpenDentBusiness."+className);
				MethodInfo methodInfo=classType.GetMethod(methodName);
				DataTable result=(DataTable)methodInfo.Invoke(null,parameters);
				return result;
				//return DataCore.GetTableByMethod(classMethod,parameters);
			}
		}*/



	}
}

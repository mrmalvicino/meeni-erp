# Meeni ERP

&nbsp;
Meeni ERP is a simple enterprise resource planning software. It performs quotations, registers sales, manages stock, schedules purchases, and keeps the accounting.

- **Web-Based Platform**: Accessible from any device with an internet connection.
- **Multi-Tenancy Support**: Supports multiple organizations, allowing independent use by different businesses.

## TOC

- [Meeni ERP](#meeni-erp)
	- [TOC](#toc)
	- [Features](#features)
	- [Technical Overview](#technical-overview)
	- [Setup and Compilation](#setup-and-compilation)
	- [License and Contributions](#license-and-contributions)

## Features

&nbsp;
Meeni ERP offers the following functionalities:
- **Quotations Management**: Create and manage customer quotations efficiently.
- **Sales Tracking**: Register and monitor sales transactions.
- **Inventory Management**: Keep track of stock levels and movements.
- **Purchase Scheduling**: Plan and organize purchases to maintain supply flow.
- **Accounting**: Simplify financial record-keeping and reporting.

## Technical Overview
- **Frontend**: ASP.NET WebForms with Bootstrap for responsive design.
- **Backend**: C# with for business logic and data management.
- **Database**: SQL Server, structured to support multi-tenancy securely.

## Setup and Compilation

1. Clone the repository:

```bash
git clone https://github.com/mrmalvicino/meeni-erp.git
```

2. Generate the database by running the provided SQL scripts.

3. Create a file named `Web.config` file with your connection string and [Mailtrap](https://mailtrap.io) API token with the following code:

```xml
<?xml version="1.0" encoding="utf-8"?>
<configuration>
	<system.web>
		<compilation debug="true" targetFramework="4.8" />
		<httpRuntime targetFramework="4.8.1" />
		<customErrors mode="Off"/>
		<pages>
			<namespaces>
				<add namespace="DomainModel" />
			</namespaces>
		</pages>
	</system.web>
	<system.webServer>
		<defaultDocument>
			<files>
				<add value="Home.aspx" />
			</files>
		</defaultDocument>
		<staticContent>
			<mimeMap fileExtension=".webmanifest" mimeType="application/manifest+json" />
		</staticContent>
	</system.webServer>
	<location path="Admin">
		<system.webServer>
			<defaultDocument>
				<files>
					<add value="Dashboard.aspx" />
				</files>
			</defaultDocument>
		</system.webServer>
	</location>
	<connectionStrings>
		<add name="SERVER_NAME" connectionString="server=SERVER_ADDRESS_OR_IP; database=meeni_erp_db; User=PASSWORD" />
	</connectionStrings>
	<appSettings>
		<add key="mailtrap_token" value="Bearer API_DE_MAILTRAP" />
		<add key="business_name" value="BUSINESS NAME" />
		<add key="business_email" value="EMAIL@DOMINIO.com" />
		<add key="business_url" value="BUSINESSURL.COM" />
	</appSettings>
	<runtime>
		<assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1">
			<dependentAssembly>
				<assemblyIdentity name="System.Runtime.CompilerServices.Unsafe" publicKeyToken="b03f5f7f11d50a3a" culture="neutral" />
				<bindingRedirect oldVersion="0.0.0.0-6.0.0.0" newVersion="6.0.0.0" />
			</dependentAssembly>
		</assemblyBinding>
	</runtime>
	<system.codedom>
		<compilers>
			<compiler language="c#;cs;csharp" extension=".cs" warningLevel="4" compilerOptions="/langversion:default /nowarn:1659;1699;1701;612;618" type="Microsoft.CodeDom.Providers.DotNetCompilerPlatform.CSharpCodeProvider, Microsoft.CodeDom.Providers.DotNetCompilerPlatform, Version=4.1.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" />
			<compiler language="vb;vbs;visualbasic;vbscript" extension=".vb" warningLevel="4" compilerOptions="/langversion:default /nowarn:41008,40000,40008 /define:_MYTYPE=\&quot;Web\&quot; /optionInfer+" type="Microsoft.CodeDom.Providers.DotNetCompilerPlatform.VBCodeProvider, Microsoft.CodeDom.Providers.DotNetCompilerPlatform, Version=4.1.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" />
		</compilers>
	</system.codedom>
</configuration>
```

1. Go to Visual Studio menu, select **Project > Manage NuGet Packages** and install the latest version of `Microsoft.CodeDom.Providers.DotNetCompilerPlatform` package.

2. Build and deploy the application to your preferred hosting environment.

## License and Contributions

&nbsp;
This is an open source project licensed under the [General GNU Public License](./LICENSE).
Contributions are welcome! Please fork the repository and create a pull request with your improvements or suggestions.
Make sure to check the [contibution guide](./doc/contribute.md) before.
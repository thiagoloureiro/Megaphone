# MegaPhone
A framework to self register services on Consul.IO

*MegaPhone*

MegaPhone is a lightweight framework to run self hosting REST services using Web Api or NancyFx ontop of a Consul or ETCD cluster. Each service will start out by allocating a free port to run on, once the service is started, it will register itself in the local cluster provider.

This project was inheritate from the original Microphone with the intention to keep the development, improvement and fixes, because the actual project is unoperative and nuget packages outdated.

**MegaPhone.Core**
[![NuGet](https://buildstats.info/nuget/Megaphone.Core)](http://www.nuget.org/packages/WebImpact.WIFramework.Megaphone.Core)

**MegaPhone.Etcd**
[![NuGet](https://buildstats.info/nuget/Megaphone.Etcd)](http://www.nuget.org/packages/WebImpact.WIFramework.Megaphone.Etcd)

**MegaPhone.Nancy**
[![NuGet](https://buildstats.info/nuget/Megaphone.Nancy)](http://www.nuget.org/packages/WebImpact.WIFramework.Megaphone.Nancy)

**MegaPhone.WebApi**
[![NuGet](https://buildstats.info/nuget/Megaphone.WebApi)](http://www.nuget.org/packages/WebImpact.WIFramework.Megaphone.WebApi)

[![Build Status](https://img.shields.io/appveyor/ci/thiagoloureiro/megaphone/master.svg)](https://ci.appveyor.com/project/thiagoloureiro/megaphone) 
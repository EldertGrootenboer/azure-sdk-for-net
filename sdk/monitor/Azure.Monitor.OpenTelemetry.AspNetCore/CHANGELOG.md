# Release History

## 1.0.0-beta.5 (2023-07-13)

### Features Added

* Added Azure.* activity sources.
  Users will need to enable the collection by turning on the feature by following one of the ways listed in
  [Introducing experimental OpenTelemetry support in the Azure SDK for .NET](https://devblogs.microsoft.com/azure-sdk/introducing-experimental-opentelemetry-support-in-the-azure-sdk-for-net/).
  ([#37505](https://github.com/Azure/azure-sdk-for-net/pull/37505))
* Added `SamplingRatio` property to customize the sampling rate in Azure Monitor Exporter.
  ([#36972](https://github.com/Azure/azure-sdk-for-net/pull/36972))

### Other Changes

* Update OpenTelemetry dependencies
  ([#36859](https://github.com/Azure/azure-sdk-for-net/pull/36859))
  - OpenTelemetry 1.5.0
  - OpenTelemetry.Extensions.Hosting 1.5.0
  - OpenTelemetry.Instrumentation.AspNetCore 1.5.0-beta.1
  - OpenTelemetry.Instrumentation.Http 1.5.0-beta.1
  - OpenTelemetry.Instrumentation.SqlClient 1.5.0-beta.1

* Removed reference to `OpenTelemetry.Extensions.AzureMonitor`.
  ([#36972](https://github.com/Azure/azure-sdk-for-net/pull/36972))

## 1.0.0-beta.4 (2023-05-09)

### Features Added

* Added ability to configure sampling percentage using `ApplicationInsightsSamplerOptions`.
([#36111](https://github.com/Azure/azure-sdk-for-net/pull/3611))

## 1.0.0-beta.3 (2023-04-11)

### Features Added

* Added new public APIs `Services.AddOpenTelemetry().UseAzureMonitor()` and `Services.AddOpenTelemetry().UseAzureMonitor(Action<AzureMonitorOptions> configureAzureMonitor)`.

### Breaking Changes

* Removed public APIs `Services.AddAzureMonitor()`, `Services.AddAzureMonitor(AzureMonitorOptions options)` and `Services.AddAzureMonitor(Action<AzureMonitorOptions> configureAzureMonitor)`.

## 1.0.0-beta.2 (2023-03-14)

### Other Changes

* Upgraded dependent `Azure.Core` to `1.30.0` due to an [issue in `ArrayBackedPropertyBag`](https://github.com/Azure/azure-sdk-for-net/pull/34800) in `Azure.Core` version `1.29.0`.

## 1.0.0-beta.1 (2023-03-07)

* Initial release of `Azure.Monitor.OpenTelemetry.AspNetCore`.

This is a beta version, so breaking changes are possible in subsequent releases as we improve the product. To provide feedback, please submit an issue in our [Azure SDK for .NET GitHub repo](https://github.com/Azure/azure-sdk-for-net/issues).

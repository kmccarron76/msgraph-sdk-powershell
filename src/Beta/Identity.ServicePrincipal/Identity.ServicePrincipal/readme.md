<!-- region Generated -->
# Microsoft.Graph.Identity.ServicePrincipal
This directory contains the PowerShell module for the IdentityServicePrincipal service.

---
## Status
[![Microsoft.Graph.Identity.ServicePrincipal](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Identity.ServicePrincipal.svg?style=flat-square&label=Microsoft.Graph.Identity.ServicePrincipal "Microsoft.Graph.Identity.ServicePrincipal")](https://www.powershellgallery.com/packages/Microsoft.Graph.Identity.ServicePrincipal/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.Identity.ServicePrincipal`, see [how-to.md](how-to.md).
<!-- endregion -->

### AutoRest Configuration

> see https://aka.ms/autorest

``` yaml
require:
  - $(this-folder)/../../../readme.graph.md
title: $(service-name)
subject-prefix: ''
input-file: $(spec-doc-repo)/$(title).yml
directive:
# Rename cmdlets
  - where:
      verb: Get
      subject: (^ServicePrincipal$)
      variant: Get1|GetExpanded
    set:
      verb: Get
      subject: $1ById
```
### Versioning

``` yaml
module-version: 0.5.1
release-notes: See https://aka.ms/GraphPowerShell-Release.
```

[![](https://img.shields.io/nuget/v/soenneker.stripe.constants.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.stripe.constants/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.stripe.constants/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.stripe.constants/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.stripe.constants.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.stripe.constants/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.stripe.constants/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.stripe.constants/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Stripe.Constants

Provides named values for common Stripe list limits, metadata keys, U.S. card and ACH fee assumptions, and payment amount boundaries.

## Installation

```bash
dotnet add package Soenneker.Stripe.Constants
```

## Usage

```csharp
using Soenneker.Stripe.Constants;

decimal estimatedCardFee =
    amount * StripeConstants.DefaultCardFeePercentage
    + StripeConstants.DefaultCardFixedFee;

int pageSize = StripeConstants.MaxListPageSize;
string userMetadataKey = StripeConstants.MetadataKeyUserId;
```

The fee and ACH soft-limit constants are reference assumptions, not values returned by Stripe for your account. Pricing, currencies, payment methods, and account-specific risk limits can differ; do not use these constants as the sole source for settlement, eligibility, or payment-acceptance decisions.

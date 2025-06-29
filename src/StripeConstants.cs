namespace Soenneker.Stripe.Constants;

/// <summary>
/// A centralized collection of constants related to Stripe’s pricing, fees, and API usage.
/// </summary>
public sealed class StripeConstants
{
    /// <summary>
    /// The default percentage fee Stripe charges per card transaction (2.9%).
    /// </summary>
    public const decimal DefaultCardFeePercentage = 0.029m;

    /// <summary>
    /// The fixed fee Stripe charges per card transaction in addition to the percentage fee ($0.30).
    /// </summary>
    public const decimal DefaultCardFixedFee = 0.30m;

    /// <summary>
    /// The percentage fee Stripe charges for ACH Direct Debit transactions (0.8%).
    /// </summary>
    public const decimal AchFeePercentage = 0.008m;

    /// <summary>
    /// The maximum fee Stripe charges for an ACH Direct Debit transaction ($5.00).
    /// </summary>
    public const decimal AchMaxFee = 5.00m;

    /// <summary>
    /// A common metadata key used to associate a Stripe object with a user ID in your system.
    /// </summary>
    public const string MetadataKeyUserId = "userId";

    /// <summary>
    /// The maximum number of items that can be requested in a single page for most Stripe list API calls.
    /// </summary>
    public const int MaxListPageSize = 100;

    /// <summary>
    /// The additional percentage fee Stripe charges for currency conversion (1.5%).
    /// </summary>
    public const decimal CurrencyConversionFeePercentage = 0.015m;
}
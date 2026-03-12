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

    /// <summary>Minimum charge Stripe accepts for card payments (USD).</summary>
    public const decimal CardMinAmount = 0.50m;

    /// <summary>Maximum charge Stripe accepts for card payments (USD).</summary>
    /// <remarks>
    /// The amount field on <c>PaymentIntent</c>/<c>Charge</c> is 8 digits max in Stripe’s
    /// API, so the highest legal USD value is 999 999.99.
    /// </remarks>
    public const decimal CardMaxAmount = 999_999.99m;

    /// <summary>
    /// Network ceiling for an individual ACH Direct Debit (same-day ACH).
    /// </summary>
    /// <remarks>
    /// ACH rules cap same-day transactions at 1 million USD. Stripe may impose lower
    /// risk limits on a per-account basis.
    /// </remarks>
    public const decimal AchMaximumDebitAmount = 1_000_000.00m;

    /// <summary>
    /// Typical per-debit limit Stripe places on brand-new U.S. accounts for ACH.
    /// Not enforced by the API layer; Stripe risk checks reject larger debits
    /// until your limit is increased.
    /// </summary>
    public const decimal AchSoftPerTransactionLimit = 6_000.00m;

    /// <summary>
    /// Typical weekly aggregate limit for new ACH users (U.S. accounts).
    /// </summary>
    public const decimal AchSoftWeeklyLimit = 10_000.00m;
}
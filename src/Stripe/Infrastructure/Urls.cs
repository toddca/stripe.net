﻿namespace Stripe
{
    internal static class Urls
    {
        public static string Disputes
        {
            get { return BaseUrl + "/disputes"; }
        }

        public static string Invoices
        {
            get { return BaseUrl + "/invoices"; }
        }

        public static string InvoiceItems
        {
            get { return BaseUrl + "/invoiceitems"; }
        }

        public static string Tokens
        {
            get { return BaseUrl + "/tokens"; }
        }

        public static string Charges
        {
            get { return BaseUrl + "/charges"; }
        }

        public static string Coupons
        {
            get { return BaseUrl + "/coupons"; }
        }

        public static string Plans
        {
            get { return BaseUrl + "/plans"; }
        }

        public static string Balance
        {
            get { return BaseUrl + "/balance"; }
        }

        public static string BalanceTransactions
        {
            get { return BaseUrl + "/balance/history"; }
        }

        public static string SpecificBalanceTransaction
        {
            get { return BalanceTransactions + "/{0}"; }
        }

        public static string Customers
        {
            get { return BaseUrl + "/customers"; }
        }

        public static string CustomerCards
        {
            get { return BaseUrl + "/customers/{0}/sources"; }
        }

        public static string RecipientCards
        {
            get { return BaseUrl + "/recipients/{0}/cards"; }
        }

        public static string Events
        {
            get { return BaseUrl + "/events"; }
        }

        public static string Accounts
        {
            get { return BaseUrl + "/accounts"; }
        }

        public static string Recipients
        {
            get { return BaseUrl + "/recipients"; }
        }

        public static string Subscriptions
        {
            get { return BaseUrl + "/customers/{0}/subscriptions"; }
        }

        public static string Transfers
        {
            get { return BaseUrl + "/transfers"; }
        }

        public static string ApplicationFees
        {
            get { return BaseUrl + "/application_fees"; }
        }

        public static string Files
        {
            get { return FileBaseUrl + "/files"; }
        }

        private static string FileBaseUrl
        {
            get { return "https://uploads.stripe.com/v1"; }
        }

        private static string BaseUrl
        {
            get { return "https://api.stripe.com/v1"; }
        }

        public static string OAuthToken
        {
            get { return BaseConnectUrl + "/oauth/token"; }
        }

        private static string BaseConnectUrl
        {
            get { return "https://connect.stripe.com"; }
        }
    }
}
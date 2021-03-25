# bets = []
# bet = []
# bet_codes = '0000:TA:PH, 1234:TB:JPN, 5678:TA:TAI'
#
# compound_bets = bet_codes.split(', ')
# for bets in compound_bets:
#     print('Individual Bet: ' + bets)   #save to database as Bet Detail
#     bet = bets.split(':')
#     number, table, region = bet
#     print('Number: ' + number)   # Save to database as Number
#     print('Table: ' + table)    # Save to database as Table
#     print('Region: ' + region)   # Save to database as Region
#     print('----------------------------')
#
# print(len(compound_bets))
#
#
#
# # print(number)
# # print(table)
# # print(region)
# # print(bet)

# --------------------------
bet = []
winning_numbers = ['0000:TA:PH', '1234:TB:JPN', '5678:TA:TAI']
bet = bet + winning_numbers

print(bet)



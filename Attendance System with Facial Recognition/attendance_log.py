import xlsxwriter

def generate_logs():
    with open("log.txt", 'r') as f:
        result = f.read()

    split_result = result.split('\n')
    split_result.pop(-1)

    names = []
    time = []
    item_split = []
    for item in split_result:
        counter = 0
        a_result = item.split(',')
        # print(a_result)
        # print(len(a_result))
        # print(type(a_result))

        for elem in a_result:
            c_result = elem.strip("'").strip(" '").strip("['").strip("']").strip('\n')
            instance = c_result
            print(instance)
            if counter < len(a_result)/2:
                names.append(instance)
                # print("True")
            else:
                time.append(instance)
                # print("False")
            counter = counter + 1
        # print("-------------------------")

    print(names)
    print(time)



    workbook = xlsxwriter.Workbook('hello.xlsx')
    worksheet = workbook.add_worksheet()

    worksheet.write('A1', 'Name')
    worksheet.write('B1', 'Time')

    for value in range(len(names)):
        worksheet.write(value+1, 0, names[value])
        worksheet.write(value+1, 1, time[value])
        
        #insert_value('poy')
    workbook.close()
    
    print('The Excel sheet has been updated. Please open the hello.xlsx file')


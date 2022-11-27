import json
import pandas as pd

df = pd.read_excel('autos.xlsx')

# print(df)

def exl_data():
    df['Time'] = round(df['Distance'] / df['Speed'], 2)
    json_str = df.to_json(orient='records')

    return json_str

# print(df)
# print('DataFrame to JSON:\n', exl_data())
#!/usr/bin/env python
# -*- coding: utf-8 -*-

import json


def read_json(json_path):
    f = open(json_path)
    json_txt = f.read()
    f.close()
    return json_txt


def write_json(json_path, json_txt):
    f = open(json_path, 'w')
    f.write(json_txt)
    f.close()


def main():
    json_path_arr = [
        '../Images/Role/role.txt'
    ]
    for json_path in json_path_arr:
        json_txt = read_json(json_path)
        json_data = json.loads(json_txt)
        if not json_data.get('formated', False):
            frames = json_data.get('frames', [])
            new_frames = []
            for key, val in frames.items():
                val['filename'] = key
                new_frames.append(val)
            json_data['frames'] = new_frames
            json_data['formated'] = True
        write_json(json_path, json.dumps(json_data))

if __name__ == '__main__':
    main()
    print('done')

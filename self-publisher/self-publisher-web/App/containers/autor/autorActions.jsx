import { GET_AUTORS_SUCCESS, GET_AUTORS_ERROR } from './autorConstants.jsx'
import "isomorphic-fetch"

export function receiveAutors(data) {
    return {
        type: GET_AUTORS_SUCCESS,
        autors: data
    }
}

export function errorReceive(err) {
    return {
        type: GET_AUTORS_ERROR,
        error: err
    }
}

export function getAutors(pageIndex = 0) {
    return (dispatch) => {
        let queryTrailer = '?pageIndex=' + pageIndex;
        fetch(constants.page + queryTrailer)
            .then((response) => {
                return response.json()
            }).then((data) => {
                dispatch(receiveAutors(data))
            }).catch((ex) => {
                dispatch(errorReceive(ex))
            });
    }
}
<?xml version="1.0" encoding="utf-8" standalone="yes" ?>
<!--Torque Constructor Scene document http://www.garagegames.com-->
<ConstructorScene version="4" creator="Torque Constructor" date="2024/01/03 16:21:17">
    <Sunlight azimuth="180" elevation="35" color="100 100 100" ambient="64 64 64" />
    <LightingOptions lightingSystem="" ineditor_defaultLightmapSize="256" ineditor_maxLightmapSize="256" ineditor_lightingPerformanceHint="0" ineditor_shadowPerformanceHint="1" ineditor_TAPCompatibility="0" ineditor_useSunlight="0" export_defaultLightmapSize="256" export_maxLightmapSize="256" export_lightingPerformanceHint="0" export_shadowPerformanceHint="1" export_TAPCompatibility="0" export_useSunlight="0" />
    <GameTypes>
        <GameType name="Constructor" />
        <GameType name="Torque" />
    </GameTypes>
    <SceneShapes nextShapeID="7">
        <SceneShape id="1" type="1" entityID="3" dl="0" group="-1" locked="0" />
        <SceneShape id="2" type="1" entityID="4" dl="0" group="-1" locked="0" />
        <SceneShape id="3" type="1" entityID="5" dl="0" group="-1" locked="0" />
        <SceneShape id="4" type="1" entityID="7" dl="0" group="-1" locked="0" />
        <SceneShape id="5" type="1" entityID="8" dl="0" group="-1" locked="0" />
        <SceneShape id="6" type="1" entityID="9" dl="0" group="-1" locked="0" />
    </SceneShapes>
    <DetailLevels current="0">
        <DetailLevel minPixelSize="0" actionCenter="0 0 0">
            <InteriorMap brushScale="32" lightScale="8" ambientColor="0 0 0" ambientColorEmerg="0 0 0">
                <Entities nextEntityID="10">
                    <Entity id="0" classname="worldspawn" gametype="Torque" isPointEntity="0">
                        <Properties detail_number="0" min_pixels="250" geometry_scale="32" light_geometry_scale="8" light_smoothing_scale="4.0" light_mesh_scale="1.0" ambient_color="0 0 0" emergency_ambient_color="0 0 0" mapversion="220" />
                    </Entity>
                    <Entity id="2" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="3" classname="path_node" gametype="Torque" isPointEntity="1" origin="30 -69.5 8" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="4" classname="path_node" gametype="Torque" isPointEntity="1" origin="30 -76.5 8" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="5" classname="path_node" gametype="Torque" isPointEntity="1" origin="30 -69.5 8" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="6" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="7" classname="path_node" gametype="Torque" isPointEntity="1" origin="-110 -70 17.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="8" classname="path_node" gametype="Torque" isPointEntity="1" origin="-110 -62 17.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="9" classname="path_node" gametype="Torque" isPointEntity="1" origin="-110 -70 17.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                </Entities>
                <Brushes nextBrushID="337">
                    <Brush id="0" owner="0" type="0" pos="0 -3 -10.5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -3 0 0 1 -10.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 6 11" />
                            <Vertex pos="3 6 -13" />
                            <Vertex pos="3 -6 11" />
                            <Vertex pos="3 -6 -13" />
                            <Vertex pos="-3 6 11" />
                            <Vertex pos="-3 6 -13" />
                            <Vertex pos="-3 -6 11" />
                            <Vertex pos="-3 -6 -13" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 -512 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -11" album="" material="bm_tile11_A" texgens="1 0 0 -256 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -13" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="1" owner="0" type="0" pos="0 -27 -8.5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -27 0 0 1 -8.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 6 13" />
                            <Vertex pos="3 6 -15" />
                            <Vertex pos="3 -6 13" />
                            <Vertex pos="3 -6 -15" />
                            <Vertex pos="-3 6 13" />
                            <Vertex pos="-3 6 -15" />
                            <Vertex pos="-3 -6 13" />
                            <Vertex pos="-3 -6 -15" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 -512 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -13" album="" material="bm_tile11_A" texgens="1 0 0 -256 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="2" owner="0" type="0" pos="0 -69 -8.5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -69 0 0 1 -8.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 12 13" />
                            <Vertex pos="3 12 -15" />
                            <Vertex pos="3 -12 13" />
                            <Vertex pos="3 -12 -15" />
                            <Vertex pos="-3 12 13" />
                            <Vertex pos="-3 12 -15" />
                            <Vertex pos="-3 -12 13" />
                            <Vertex pos="-3 -12 -15" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 -1280 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 1024 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -12" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -12" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -13" album="" material="bm_tile11_A" texgens="1 0 0 -256 0 -1 0 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="3" owner="0" type="0" pos="-9 -66 -5.5" rot="1 0 0 0" scale="" transform="1 0 0 -9 0 1 0 -66 0 0 1 -5.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 3 16" />
                            <Vertex pos="6 3 -18" />
                            <Vertex pos="6 -3 16" />
                            <Vertex pos="6 -3 -18" />
                            <Vertex pos="-6 3 16" />
                            <Vertex pos="-6 3 -18" />
                            <Vertex pos="-6 -3 16" />
                            <Vertex pos="-6 -3 -18" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 -896 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 640 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -512 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16" album="" material="bm_tile11_A" texgens="1 0 0 -1024 0 -1 0 1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -18" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="4" owner="0" type="0" pos="-3.25 -3 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -3.25 0 1 0 -3 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 6 0.25" />
                            <Vertex pos="0.25 6 -0.25" />
                            <Vertex pos="0.25 -6 0.25" />
                            <Vertex pos="0.25 -6 -0.25" />
                            <Vertex pos="-0.25 6 0.25" />
                            <Vertex pos="-0.25 6 -0.25" />
                            <Vertex pos="-0.25 -6 0.25" />
                            <Vertex pos="-0.25 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="5" owner="0" type="0" pos="3.25 -3 0.25" rot="1 0 0 0" scale="" transform="1 0 0 3.25 0 1 0 -3 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 6 0.25" />
                            <Vertex pos="0.25 6 -0.25" />
                            <Vertex pos="0.25 -6 0.25" />
                            <Vertex pos="0.25 -6 -0.25" />
                            <Vertex pos="-0.25 6 0.25" />
                            <Vertex pos="-0.25 6 -0.25" />
                            <Vertex pos="-0.25 -6 0.25" />
                            <Vertex pos="-0.25 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="6" owner="0" type="0" pos="0 3.25 0.25" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 3.25 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.5 0.25 0.25" />
                            <Vertex pos="3.5 0.25 -0.25" />
                            <Vertex pos="3.5 -0.25 0.25" />
                            <Vertex pos="3.5 -0.25 -0.25" />
                            <Vertex pos="-3.5 0.25 0.25" />
                            <Vertex pos="-3.5 0.25 -0.25" />
                            <Vertex pos="-3.5 -0.25 0.25" />
                            <Vertex pos="-3.5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3.5" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3.5" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -768 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 896 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="7" owner="0" type="0" pos="3 -9.25 0.25" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 -9.25 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.25 0.25" />
                            <Vertex pos="0.5 0.25 -0.25" />
                            <Vertex pos="0.5 -0.25 0.25" />
                            <Vertex pos="0.5 -0.25 -0.25" />
                            <Vertex pos="-0.5 0.25 0.25" />
                            <Vertex pos="-0.5 0.25 -0.25" />
                            <Vertex pos="-0.5 -0.25 0.25" />
                            <Vertex pos="-0.5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="8" owner="0" type="0" pos="-3 -9.25 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 -9.25 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.25 0.25" />
                            <Vertex pos="0.5 0.25 -0.25" />
                            <Vertex pos="0.5 -0.25 0.25" />
                            <Vertex pos="0.5 -0.25 -0.25" />
                            <Vertex pos="-0.5 0.25 0.25" />
                            <Vertex pos="-0.5 0.25 -0.25" />
                            <Vertex pos="-0.5 -0.25 0.25" />
                            <Vertex pos="-0.5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="9" owner="0" type="0" pos="0 -9.25 0.25" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -9.25 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 0.25 0.25" />
                            <Vertex pos="1.5 0.25 -0.25" />
                            <Vertex pos="1.5 -0.25 0.25" />
                            <Vertex pos="1.5 -0.25 -0.25" />
                            <Vertex pos="-1.5 0.25 0.25" />
                            <Vertex pos="-1.5 0.25 -0.25" />
                            <Vertex pos="-1.5 -0.25 0.25" />
                            <Vertex pos="-1.5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.5" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1.5" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 256 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -128 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="10" owner="0" type="0" pos="3 -20.75 4.25" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 -20.75 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.25 0.25" />
                            <Vertex pos="0.5 0.25 -0.25" />
                            <Vertex pos="0.5 -0.25 0.25" />
                            <Vertex pos="0.5 -0.25 -0.25" />
                            <Vertex pos="-0.5 0.25 0.25" />
                            <Vertex pos="-0.5 0.25 -0.25" />
                            <Vertex pos="-0.5 -0.25 0.25" />
                            <Vertex pos="-0.5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="11" owner="0" type="0" pos="-3 -20.75 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 -20.75 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.25 0.25" />
                            <Vertex pos="0.5 0.25 -0.25" />
                            <Vertex pos="0.5 -0.25 0.25" />
                            <Vertex pos="0.5 -0.25 -0.25" />
                            <Vertex pos="-0.5 0.25 0.25" />
                            <Vertex pos="-0.5 0.25 -0.25" />
                            <Vertex pos="-0.5 -0.25 0.25" />
                            <Vertex pos="-0.5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="12" owner="0" type="0" pos="0 -20.75 4.25" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -20.75 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 0.25 0.25" />
                            <Vertex pos="1.5 0.25 -0.25" />
                            <Vertex pos="1.5 -0.25 0.25" />
                            <Vertex pos="1.5 -0.25 -0.25" />
                            <Vertex pos="-1.5 0.25 0.25" />
                            <Vertex pos="-1.5 0.25 -0.25" />
                            <Vertex pos="-1.5 -0.25 0.25" />
                            <Vertex pos="-1.5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.5" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1.5" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 256 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -128 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="13" owner="0" type="0" pos="-3.25 -27 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -3.25 0 1 0 -27 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 6 0.25" />
                            <Vertex pos="0.25 6 -0.25" />
                            <Vertex pos="0.25 -6 0.25" />
                            <Vertex pos="0.25 -6 -0.25" />
                            <Vertex pos="-0.25 6 0.25" />
                            <Vertex pos="-0.25 6 -0.25" />
                            <Vertex pos="-0.25 -6 0.25" />
                            <Vertex pos="-0.25 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="14" owner="0" type="0" pos="3.25 -27 4.25" rot="1 0 0 0" scale="" transform="1 0 0 3.25 0 1 0 -27 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 6 0.25" />
                            <Vertex pos="0.25 6 -0.25" />
                            <Vertex pos="0.25 -6 0.25" />
                            <Vertex pos="0.25 -6 -0.25" />
                            <Vertex pos="-0.25 6 0.25" />
                            <Vertex pos="-0.25 6 -0.25" />
                            <Vertex pos="-0.25 -6 0.25" />
                            <Vertex pos="-0.25 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="15" owner="0" type="0" pos="3 -33.25 4.25" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 -33.25 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.25 0.25" />
                            <Vertex pos="0.5 0.25 -0.25" />
                            <Vertex pos="0.5 -0.25 0.25" />
                            <Vertex pos="0.5 -0.25 -0.25" />
                            <Vertex pos="-0.5 0.25 0.25" />
                            <Vertex pos="-0.5 0.25 -0.25" />
                            <Vertex pos="-0.5 -0.25 0.25" />
                            <Vertex pos="-0.5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="16" owner="0" type="0" pos="-3 -33.25 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 -33.25 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.25 0.25" />
                            <Vertex pos="0.5 0.25 -0.25" />
                            <Vertex pos="0.5 -0.25 0.25" />
                            <Vertex pos="0.5 -0.25 -0.25" />
                            <Vertex pos="-0.5 0.25 0.25" />
                            <Vertex pos="-0.5 0.25 -0.25" />
                            <Vertex pos="-0.5 -0.25 0.25" />
                            <Vertex pos="-0.5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="17" owner="0" type="0" pos="0 -33.25 4.25" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -33.25 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 0.25 0.25" />
                            <Vertex pos="1.5 0.25 -0.25" />
                            <Vertex pos="1.5 -0.25 0.25" />
                            <Vertex pos="1.5 -0.25 -0.25" />
                            <Vertex pos="-1.5 0.25 0.25" />
                            <Vertex pos="-1.5 0.25 -0.25" />
                            <Vertex pos="-1.5 -0.25 0.25" />
                            <Vertex pos="-1.5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.5" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1.5" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 256 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -128 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="18" owner="0" type="0" pos="-2 -36 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -2 0 1 0 -36 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 3 0.25" />
                            <Vertex pos="0.5 3 -0.25" />
                            <Vertex pos="0.5 -3 0.25" />
                            <Vertex pos="0.5 -3 -0.25" />
                            <Vertex pos="-0.5 3 0.25" />
                            <Vertex pos="-0.5 3 -0.25" />
                            <Vertex pos="-0.5 -3 0.25" />
                            <Vertex pos="-0.5 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 -3584 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 3712 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile05_C" texgens="1 0 0 256 0 -1 0 1536 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="19" owner="0" type="0" pos="2 -34 4.25" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 -34 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 1 0.25" />
                            <Vertex pos="0.5 1 -0.25" />
                            <Vertex pos="0.5 -1 0.25" />
                            <Vertex pos="0.5 -1 -0.25" />
                            <Vertex pos="-0.5 1 0.25" />
                            <Vertex pos="-0.5 1 -0.25" />
                            <Vertex pos="-0.5 -1 0.25" />
                            <Vertex pos="-0.5 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 -3072 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 3200 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile05_C" texgens="1 0 0 256 0 -1 0 512 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="20" owner="0" type="0" pos="3 -56.75 4.25" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 -56.75 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.25 0.25" />
                            <Vertex pos="0.5 0.25 -0.25" />
                            <Vertex pos="0.5 -0.25 0.25" />
                            <Vertex pos="0.5 -0.25 -0.25" />
                            <Vertex pos="-0.5 0.25 0.25" />
                            <Vertex pos="-0.5 0.25 -0.25" />
                            <Vertex pos="-0.5 -0.25 0.25" />
                            <Vertex pos="-0.5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="21" owner="0" type="0" pos="-0.75 -56.75 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -0.75 0 1 0 -56.75 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.25 0.25 0.25" />
                            <Vertex pos="2.25 0.25 -0.25" />
                            <Vertex pos="2.25 -0.25 0.25" />
                            <Vertex pos="2.25 -0.25 -0.25" />
                            <Vertex pos="-2.25 0.25 0.25" />
                            <Vertex pos="-2.25 0.25 -0.25" />
                            <Vertex pos="-2.25 -0.25 0.25" />
                            <Vertex pos="-2.25 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2.25" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.25" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="22" owner="0" type="0" pos="-3.25 -58 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -3.25 0 1 0 -58 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1.5 0.25" />
                            <Vertex pos="0.25 1.5 -0.25" />
                            <Vertex pos="0.25 -1.5 0.25" />
                            <Vertex pos="0.25 -1.5 -0.25" />
                            <Vertex pos="-0.25 1.5 0.25" />
                            <Vertex pos="-0.25 1.5 -0.25" />
                            <Vertex pos="-0.25 -1.5 0.25" />
                            <Vertex pos="-0.25 -1.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -2048 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 2176 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.5" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 2176 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 2176 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="23" owner="0" type="0" pos="-3.25 -61.75 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -3.25 0 1 0 -61.75 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1.25 0.25" />
                            <Vertex pos="0.25 1.25 -0.25" />
                            <Vertex pos="0.25 -1.25 0.25" />
                            <Vertex pos="0.25 -1.25 -0.25" />
                            <Vertex pos="-0.25 1.25 0.25" />
                            <Vertex pos="-0.25 1.25 -0.25" />
                            <Vertex pos="-0.25 -1.25 0.25" />
                            <Vertex pos="-0.25 -1.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1984 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 2112 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="24" owner="0" type="0" pos="2 -56 4.25" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 -56 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 1 0.25" />
                            <Vertex pos="0.5 1 -0.25" />
                            <Vertex pos="0.5 -1 0.25" />
                            <Vertex pos="0.5 -1 -0.25" />
                            <Vertex pos="-0.5 1 0.25" />
                            <Vertex pos="-0.5 1 -0.25" />
                            <Vertex pos="-0.5 -1 0.25" />
                            <Vertex pos="-0.5 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 -3072 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 3200 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile05_C" texgens="1 0 0 256 0 -1 0 512 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="25" owner="0" type="0" pos="-6 -60 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 -60 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.5 0.25" />
                            <Vertex pos="3 0.5 -0.25" />
                            <Vertex pos="3 -0.5 0.25" />
                            <Vertex pos="3 -0.5 -0.25" />
                            <Vertex pos="-3 0.5 0.25" />
                            <Vertex pos="-3 0.5 -0.25" />
                            <Vertex pos="-3 -0.5 0.25" />
                            <Vertex pos="-3 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 -3200 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 3328 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile05_C" texgens="1 0 0 -1024 0 -1 0 768 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="26" owner="0" type="0" pos="3.25 -67.25 4.25" rot="1 0 0 0" scale="" transform="1 0 0 3.25 0 1 0 -67.25 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 10.25 0.25" />
                            <Vertex pos="0.25 10.25 -0.25" />
                            <Vertex pos="0.25 -10.25 0.25" />
                            <Vertex pos="0.25 -10.25 -0.25" />
                            <Vertex pos="-0.25 10.25 0.25" />
                            <Vertex pos="-0.25 10.25 -0.25" />
                            <Vertex pos="-0.25 -10.25 0.25" />
                            <Vertex pos="-0.25 -10.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -2496 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 2624 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -10.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -10.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 2624 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 2624 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="27" owner="0" type="0" pos="3.25 -79.75 4.25" rot="1 0 0 0" scale="" transform="1 0 0 3.25 0 1 0 -79.75 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1.25 0.25" />
                            <Vertex pos="0.25 1.25 -0.25" />
                            <Vertex pos="0.25 -1.25 0.25" />
                            <Vertex pos="0.25 -1.25 -0.25" />
                            <Vertex pos="-0.25 1.25 0.25" />
                            <Vertex pos="-0.25 1.25 -0.25" />
                            <Vertex pos="-0.25 -1.25 0.25" />
                            <Vertex pos="-0.25 -1.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1984 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 2112 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="28" owner="0" type="0" pos="2 -9.5 0.25" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 -9.5 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.25" />
                            <Vertex pos="0.5 0.5 -0.25" />
                            <Vertex pos="0.5 -0.5 0.25" />
                            <Vertex pos="0.5 -0.5 -0.25" />
                            <Vertex pos="-0.5 0.5 0.25" />
                            <Vertex pos="-0.5 0.5 -0.25" />
                            <Vertex pos="-0.5 -0.5 0.25" />
                            <Vertex pos="-0.5 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 -2944 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 3072 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile05_C" texgens="1 0 0 256 0 -1 0 256 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="29" owner="0" type="0" pos="2 -10.5 0.375" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 -10.5 0 0 1 0.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.125" />
                            <Vertex pos="0.5 0.5 -0.375" />
                            <Vertex pos="0.5 -0.5 0.375" />
                            <Vertex pos="0.5 -0.5 -0.125001" />
                            <Vertex pos="-0.5 0.5 0.125" />
                            <Vertex pos="-0.5 0.5 -0.375" />
                            <Vertex pos="-0.5 -0.5 0.375" />
                            <Vertex pos="-0.5 -0.5 -0.125001" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 -2944 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 3072 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970143 -0.242536" album="" material="bm_tile05_C" texgens="1 0 0 256 0 -1 0 256 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242535 -0.970143 -0.242536" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="30" owner="0" type="0" pos="2 -20.5 4.25" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 -20.5 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.25" />
                            <Vertex pos="0.5 0.5 -0.25" />
                            <Vertex pos="0.5 -0.5 0.25" />
                            <Vertex pos="0.5 -0.5 -0.25" />
                            <Vertex pos="-0.5 0.5 0.25" />
                            <Vertex pos="-0.5 0.5 -0.25" />
                            <Vertex pos="-0.5 -0.5 0.25" />
                            <Vertex pos="-0.5 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 -2944 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 3072 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile05_C" texgens="1 0 0 256 0 -1 0 256 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="31" owner="0" type="0" pos="2 -19.5 4.125" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 -19.5 0 0 1 4.125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.125" />
                            <Vertex pos="0.5 0.5 -0.375" />
                            <Vertex pos="0.5 -0.5 0.375" />
                            <Vertex pos="0.5 -0.5 -0.125" />
                            <Vertex pos="-0.5 0.5 0.125" />
                            <Vertex pos="-0.5 0.5 -0.375" />
                            <Vertex pos="-0.5 -0.5 0.375" />
                            <Vertex pos="-0.5 -0.5 -0.125" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 -2944 0 0 -1 -32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 3072 0 0 -1 -32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 -32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 -32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970143 -0.242536" album="" material="bm_tile05_C" texgens="1 0 0 256 0 -1 0 256 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970143 -0.242536" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="32" owner="0" type="0" pos="2 -15 2.25" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 -15 0 0 1 2.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 4 -1.5" />
                            <Vertex pos="0.5 4 -2" />
                            <Vertex pos="0.5 -4 2" />
                            <Vertex pos="0.5 -4 1.5" />
                            <Vertex pos="-0.5 4 -1.5" />
                            <Vertex pos="-0.5 4 -2" />
                            <Vertex pos="-0.5 -4 2" />
                            <Vertex pos="-0.5 -4 1.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 -2048 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 2176 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.400819 0.916157 -0.229039" album="" material="bm_tile05_C" texgens="1 0 0 256 0 -1 0 -1536 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.400819 -0.916157 -0.229039" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="33" owner="0" type="0" pos="-2 -9.5 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -2 0 1 0 -9.5 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.25" />
                            <Vertex pos="0.5 0.5 -0.25" />
                            <Vertex pos="0.5 -0.5 0.25" />
                            <Vertex pos="0.5 -0.5 -0.25" />
                            <Vertex pos="-0.5 0.5 0.25" />
                            <Vertex pos="-0.5 0.5 -0.25" />
                            <Vertex pos="-0.5 -0.5 0.25" />
                            <Vertex pos="-0.5 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 -2944 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 3072 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile05_C" texgens="1 0 0 256 0 -1 0 256 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="34" owner="0" type="0" pos="-2 -10.5 0.375" rot="1 0 0 0" scale="" transform="1 0 0 -2 0 1 0 -10.5 0 0 1 0.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.125" />
                            <Vertex pos="0.5 0.5 -0.375" />
                            <Vertex pos="0.5 -0.5 0.375" />
                            <Vertex pos="0.5 -0.5 -0.125001" />
                            <Vertex pos="-0.5 0.5 0.125" />
                            <Vertex pos="-0.5 0.5 -0.375" />
                            <Vertex pos="-0.5 -0.5 0.375" />
                            <Vertex pos="-0.5 -0.5 -0.125001" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 -2944 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 3072 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970143 -0.242536" album="" material="bm_tile05_C" texgens="1 0 0 256 0 -1 0 256 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242535 -0.970143 -0.242536" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="35" owner="0" type="0" pos="-2 -20.5 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -2 0 1 0 -20.5 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.25" />
                            <Vertex pos="0.5 0.5 -0.25" />
                            <Vertex pos="0.5 -0.5 0.25" />
                            <Vertex pos="0.5 -0.5 -0.25" />
                            <Vertex pos="-0.5 0.5 0.25" />
                            <Vertex pos="-0.5 0.5 -0.25" />
                            <Vertex pos="-0.5 -0.5 0.25" />
                            <Vertex pos="-0.5 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 -2944 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 3072 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile05_C" texgens="1 0 0 256 0 -1 0 256 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="36" owner="0" type="0" pos="-2 -19.5 4.125" rot="1 0 0 0" scale="" transform="1 0 0 -2 0 1 0 -19.5 0 0 1 4.125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.125" />
                            <Vertex pos="0.5 0.5 -0.375" />
                            <Vertex pos="0.5 -0.5 0.375" />
                            <Vertex pos="0.5 -0.5 -0.125" />
                            <Vertex pos="-0.5 0.5 0.125" />
                            <Vertex pos="-0.5 0.5 -0.375" />
                            <Vertex pos="-0.5 -0.5 0.375" />
                            <Vertex pos="-0.5 -0.5 -0.125" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 -2944 0 0 -1 -32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 3072 0 0 -1 -32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 -32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 -32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970143 -0.242536" album="" material="bm_tile05_C" texgens="1 0 0 256 0 -1 0 256 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970143 -0.242536" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="37" owner="0" type="0" pos="-2 -15 2.25" rot="1 0 0 0" scale="" transform="1 0 0 -2 0 1 0 -15 0 0 1 2.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 4 -1.5" />
                            <Vertex pos="0.5 4 -2" />
                            <Vertex pos="0.5 -4 2" />
                            <Vertex pos="0.5 -4 1.5" />
                            <Vertex pos="-0.5 4 -1.5" />
                            <Vertex pos="-0.5 4 -2" />
                            <Vertex pos="-0.5 -4 2" />
                            <Vertex pos="-0.5 -4 1.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 -2048 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 2176 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.400819 0.916157 -0.229039" album="" material="bm_tile05_C" texgens="1 0 0 256 0 -1 0 -1536 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.400819 -0.916157 -0.229039" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="38" owner="0" type="0" pos="-3.5 -38.5 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -3.5 0 1 0 -38.5 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.5 0.25" />
                            <Vertex pos="1 0.5 -0.25" />
                            <Vertex pos="1 -0.5 0.25" />
                            <Vertex pos="1 -0.5 -0.25" />
                            <Vertex pos="-1 0.5 0.25" />
                            <Vertex pos="-1 0.5 -0.25" />
                            <Vertex pos="-1 -0.5 0.25" />
                            <Vertex pos="-1 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -2944 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 3072 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile05_C" texgens="1 0 0 0 0 -1 0 256 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="39" owner="0" type="0" pos="-5 -38.5 4" rot="1 0 0 0" scale="" transform="1 0 0 -5 0 1 0 -38.5 0 0 1 4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.500004 0.5" />
                            <Vertex pos="0.5 0.500004 4.76837e-007" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 4.76837e-007" />
                            <Vertex pos="-0.5 0.500004 -2.38419e-007" />
                            <Vertex pos="-0.5 0.500004 -0.5" />
                            <Vertex pos="-0.5 -0.5 -2.38419e-007" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 -2944 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 3072 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.500004" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.447214 0 0.894427 -0.223607" album="" material="bm_friction_ice" texgens="1 0 0 -2560 0 -1 0 19712 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.447214 0 -0.894427 -0.223607" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="40" owner="0" type="0" pos="-6.5 -38.5 3.75" rot="1 0 0 0" scale="" transform="1 0 0 -6.5 0 1 0 -38.5 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.5 0.25" />
                            <Vertex pos="1 0.5 -0.25" />
                            <Vertex pos="1 -0.5 0.25" />
                            <Vertex pos="1 -0.5 -0.25" />
                            <Vertex pos="-1 0.5 0.25" />
                            <Vertex pos="-1 0.5 -0.25" />
                            <Vertex pos="-1 -0.5 0.25" />
                            <Vertex pos="-1 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -2944 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 3072 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_friction_ice" texgens="1 0 0 -3328 0 -1 0 19712 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="41" owner="0" type="0" pos="-8 -38.5 4" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 -38.5 0 0 1 4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.500004 0" />
                            <Vertex pos="0.5 0.500004 -0.5" />
                            <Vertex pos="0.5 -0.5 0" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.500004 0.5" />
                            <Vertex pos="-0.5 0.500004 0" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 0" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 -2944 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 3072 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.500004" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.447214 0 0.894427 -0.223607" album="" material="bm_friction_ice" texgens="1 0 0 -4096 0 -1 0 19712 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.447214 0 -0.894427 -0.223607" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="42" owner="0" type="0" pos="-10.5 -38.5 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -10.5 0 1 0 -38.5 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.5 0.25" />
                            <Vertex pos="2 0.5 -0.25" />
                            <Vertex pos="2 -0.5 0.25" />
                            <Vertex pos="2 -0.5 -0.25" />
                            <Vertex pos="-2 0.5 0.25" />
                            <Vertex pos="-2 0.5 -0.25" />
                            <Vertex pos="-2 -0.5 0.25" />
                            <Vertex pos="-2 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -2944 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 3072 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile05_C" texgens="1 0 0 -512 0 -1 0 256 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="43" owner="0" type="0" pos="-12 -41 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -12 0 1 0 -41 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 2 0.25" />
                            <Vertex pos="0.5 2 -0.25" />
                            <Vertex pos="0.5 -2 0.25" />
                            <Vertex pos="0.5 -2 -0.25" />
                            <Vertex pos="-0.5 2 0.25" />
                            <Vertex pos="-0.5 2 -0.25" />
                            <Vertex pos="-0.5 -2 0.25" />
                            <Vertex pos="-0.5 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 -3328 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 3456 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_trim" texgens="1 0 0 -768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile05_C" texgens="1 0 0 -1280 0 -1 0 1024 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 896 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="44" owner="0" type="0" pos="-12 -47 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -12 0 1 0 -47 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 2 0.25" />
                            <Vertex pos="0.5 2 -0.25" />
                            <Vertex pos="0.5 -2 0.25" />
                            <Vertex pos="0.5 -2 -0.25" />
                            <Vertex pos="-0.5 2 0.25" />
                            <Vertex pos="-0.5 2 -0.25" />
                            <Vertex pos="-0.5 -2 0.25" />
                            <Vertex pos="-0.5 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 -3328 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 3456 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_trim" texgens="-1 0 0 896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile05_C" texgens="1 0 0 -1280 0 -1 0 1024 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 896 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="45" owner="0" type="0" pos="5 -78 4.25" rot="1 0 0 0" scale="" transform="1 0 0 5 0 1 0 -78 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.5 0.25" />
                            <Vertex pos="2 0.5 -0.25" />
                            <Vertex pos="2 -0.5 0.25" />
                            <Vertex pos="2 -0.5 -0.25" />
                            <Vertex pos="-2 0.5 0.25" />
                            <Vertex pos="-2 0.5 -0.25" />
                            <Vertex pos="-2 -0.5 0.25" />
                            <Vertex pos="-2 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -3200 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 3328 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1024 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile05_C" texgens="1 0 0 -1536 0 -1 0 768 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 1024 0 -1 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="46" owner="0" type="0" pos="7.5 -78 4.375" rot="1 0 0 0" scale="" transform="1 0 0 7.5 0 1 0 -78 0 0 1 4.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.375" />
                            <Vertex pos="0.5 0.5 -0.125" />
                            <Vertex pos="0.5 -0.5 0.375" />
                            <Vertex pos="0.5 -0.5 -0.125" />
                            <Vertex pos="-0.5 0.5 0.125" />
                            <Vertex pos="-0.5 0.5 -0.375" />
                            <Vertex pos="-0.5 -0.5 0.125" />
                            <Vertex pos="-0.5 -0.5 -0.375" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 -3200 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 3328 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1408 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -1280 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 -0.242536" album="" material="bm_tile05_C" texgens="1 0 0 -2304 0 -1 0 768 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970143 -0.242536" album="" material="bm_grid_blank4" texgens="-1 0 0 1408 0 -1 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="47" owner="0" type="0" pos="8.5 -78 4.75" rot="1 0 0 0" scale="" transform="1 0 0 8.5 0 1 0 -78 0 0 1 4.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 0" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 0" />
                            <Vertex pos="-0.5 0.5 0" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 -3200 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 3328 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1408 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -1280 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.447214 0 0.894427 -0.223607" album="" material="bm_tile05_C" texgens="1 0 0 -2304 0 -1 0 768 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.447214 0 -0.894427 -0.223607" album="" material="bm_grid_blank4" texgens="-1 0 0 1408 0 -1 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="48" owner="0" type="0" pos="13 -78 5.75" rot="1 0 0 0" scale="" transform="1 0 0 13 0 1 0 -78 0 0 1 5.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.5 0.25" />
                            <Vertex pos="2 0.5 -0.25" />
                            <Vertex pos="2 -0.5 0.25" />
                            <Vertex pos="2 -0.5 -0.25" />
                            <Vertex pos="-2 0.5 0.25" />
                            <Vertex pos="-2 0.5 -0.25" />
                            <Vertex pos="-2 -0.5 0.25" />
                            <Vertex pos="-2 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -3200 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 3328 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1024 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile05_C" texgens="1 0 0 -1536 0 -1 0 768 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 1024 0 -1 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="49" owner="0" type="0" pos="15.5 -79.5 5.75" rot="1 0 0 0" scale="" transform="1 0 0 15.5 0 1 0 -79.5 0 0 1 5.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 2 0.25" />
                            <Vertex pos="0.5 2 -0.25" />
                            <Vertex pos="0.5 -2 0.25" />
                            <Vertex pos="0.5 -2 -0.25" />
                            <Vertex pos="-0.5 2 0.25" />
                            <Vertex pos="-0.5 2 -0.25" />
                            <Vertex pos="-0.5 -2 0.25" />
                            <Vertex pos="-0.5 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 -3584 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 3712 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_trim" texgens="-1 0 0 1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -1280 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile05_C" texgens="1 0 0 -2304 0 -1 0 1536 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 1408 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="50" owner="0" type="0" pos="17 -81 5.75" rot="1 0 0 0" scale="" transform="1 0 0 17 0 1 0 -81 0 0 1 5.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.5 0.25" />
                            <Vertex pos="1 0.5 -0.25" />
                            <Vertex pos="1 -0.5 0.25" />
                            <Vertex pos="1 -0.5 -0.25" />
                            <Vertex pos="-1 0.5 0.25" />
                            <Vertex pos="-1 0.5 -0.25" />
                            <Vertex pos="-1 -0.5 0.25" />
                            <Vertex pos="-1 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -3200 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 3328 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1280 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -1152 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile05_C" texgens="1 0 0 -2048 0 -1 0 768 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 1280 0 -1 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="51" owner="0" type="0" pos="18.5 -81 5.875" rot="1 0 0 0" scale="" transform="1 0 0 18.5 0 1 0 -81 0 0 1 5.875 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.375" />
                            <Vertex pos="0.5 0.5 -0.125" />
                            <Vertex pos="0.5 -0.5 0.375" />
                            <Vertex pos="0.5 -0.5 -0.125" />
                            <Vertex pos="-0.5 0.5 0.125" />
                            <Vertex pos="-0.5 0.5 -0.375" />
                            <Vertex pos="-0.5 -0.5 0.125" />
                            <Vertex pos="-0.5 -0.5 -0.375" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 -3200 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 3328 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1408 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -1280 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 -0.242536" album="" material="bm_tile05_C" texgens="1 0 0 -2304 0 -1 0 768 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970143 -0.242536" album="" material="bm_grid_blank4" texgens="-1 0 0 1408 0 -1 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="52" owner="0" type="0" pos="19.5 -81 6.25" rot="1 0 0 0" scale="" transform="1 0 0 19.5 0 1 0 -81 0 0 1 6.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 0" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 0" />
                            <Vertex pos="-0.5 0.5 4.76837e-007" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 4.76837e-007" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 -3200 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 3328 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1408 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -1280 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.447213 0 0.894427 -0.223607" album="" material="bm_tile05_C" texgens="1 0 0 -2304 0 -1 0 768 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.447214 0 -0.894427 -0.223607" album="" material="bm_grid_blank4" texgens="-1 0 0 1408 0 -1 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="53" owner="0" type="0" pos="20.5 -81 6.625" rot="1 0 0 0" scale="" transform="1 0 0 20.5 0 1 0 -81 0 0 1 6.625 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.375" />
                            <Vertex pos="0.5 0.5 -0.125" />
                            <Vertex pos="0.5 -0.5 0.375" />
                            <Vertex pos="0.5 -0.5 -0.125" />
                            <Vertex pos="-0.5 0.5 0.125" />
                            <Vertex pos="-0.5 0.5 -0.375" />
                            <Vertex pos="-0.5 -0.5 0.125" />
                            <Vertex pos="-0.5 -0.5 -0.375" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 -3200 0 0 -1 -160 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 3328 0 0 -1 -160 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1408 0 0 -1 -160 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -1280 0 0 -1 -160 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 -0.242536" album="" material="bm_tile05_C" texgens="1 0 0 -2304 0 -1 0 768 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970143 -0.242536" album="" material="bm_grid_blank4" texgens="-1 0 0 1408 0 -1 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="54" owner="0" type="0" pos="22 -81 6.75" rot="1 0 0 0" scale="" transform="1 0 0 22 0 1 0 -81 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.5 0.25" />
                            <Vertex pos="1 0.5 -0.25" />
                            <Vertex pos="1 -0.5 0.25" />
                            <Vertex pos="1 -0.5 -0.25" />
                            <Vertex pos="-1 0.5 0.25" />
                            <Vertex pos="-1 0.5 -0.25" />
                            <Vertex pos="-1 -0.5 0.25" />
                            <Vertex pos="-1 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -3200 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 3328 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1280 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -1152 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile05_C" texgens="1 0 0 -2048 0 -1 0 768 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 1280 0 -1 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="55" owner="0" type="0" pos="24 -79 6.75" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 -79 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 0.25" />
                            <Vertex pos="1 3 -0.25" />
                            <Vertex pos="1 -3 0.25" />
                            <Vertex pos="1 -3 -0.25" />
                            <Vertex pos="-1 3 0.25" />
                            <Vertex pos="-1 3 -0.25" />
                            <Vertex pos="-1 -3 0.25" />
                            <Vertex pos="-1 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -2432 0 0 -1 -480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 2176 0 0 -1 -480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 -480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -384 0 0 -1 -480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile11_A" texgens="1 0 0 -768 0 -1 0 4864 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 2688 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="56" owner="0" type="0" pos="-3.25 -75 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -3.25 0 1 0 -75 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 6 0.25" />
                            <Vertex pos="0.25 6 -0.25" />
                            <Vertex pos="0.25 -6 0.25" />
                            <Vertex pos="0.25 -6 -0.25" />
                            <Vertex pos="-0.25 6 0.25" />
                            <Vertex pos="-0.25 6 -0.25" />
                            <Vertex pos="-0.25 -6 0.25" />
                            <Vertex pos="-0.25 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -3200 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 3328 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 3328 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 3328 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="57" owner="0" type="0" pos="0 -81.25 4.25" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -81.25 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.5 0.25 0.25" />
                            <Vertex pos="3.5 0.25 -0.25" />
                            <Vertex pos="3.5 -0.25 0.25" />
                            <Vertex pos="3.5 -0.25 -0.25" />
                            <Vertex pos="-3.5 0.25 0.25" />
                            <Vertex pos="-3.5 0.25 -0.25" />
                            <Vertex pos="-3.5 -0.25 0.25" />
                            <Vertex pos="-3.5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3.5" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3.5" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 256 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -128 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="58" owner="0" type="0" pos="26 -75 6.75" rot="1 0 0 0" scale="" transform="1 0 0 26 0 1 0 -75 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 0.25" />
                            <Vertex pos="1 3 -0.25" />
                            <Vertex pos="1 -3 0.25" />
                            <Vertex pos="1 -3 -0.25" />
                            <Vertex pos="-1 3 0.25" />
                            <Vertex pos="-1 3 -0.25" />
                            <Vertex pos="-1 -3 0.25" />
                            <Vertex pos="-1 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -2432 0 0 -1 -480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 2176 0 0 -1 -480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 -480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -384 0 0 -1 -480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile11_A" texgens="1 0 0 -768 0 -1 0 4864 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 2688 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="59" owner="0" type="0" pos="21 -66 -5.5" rot="1 0 0 0" scale="" transform="1 0 0 21 0 1 0 -66 0 0 1 -5.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 3 16" />
                            <Vertex pos="6 3 -18" />
                            <Vertex pos="6 -3 16" />
                            <Vertex pos="6 -3 -18" />
                            <Vertex pos="-6 3 16" />
                            <Vertex pos="-6 3 -18" />
                            <Vertex pos="-6 -3 16" />
                            <Vertex pos="-6 -3 -18" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 -896 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 640 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -512 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16" album="" material="bm_tile11_A" texgens="1 0 0 -1024 0 -1 0 1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -18" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="60" owner="0" type="0" pos="17 -73 5.75" rot="1 0 0 0" scale="" transform="1 0 0 17 0 1 0 -73 0 0 1 5.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.5 0.25" />
                            <Vertex pos="2 0.5 -0.25" />
                            <Vertex pos="2 -0.5 0.25" />
                            <Vertex pos="2 -0.5 -0.25" />
                            <Vertex pos="-2 0.5 0.25" />
                            <Vertex pos="-2 0.5 -0.25" />
                            <Vertex pos="-2 -0.5 0.25" />
                            <Vertex pos="-2 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -3200 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 3328 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1024 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_friction_mud" texgens="1 0 0 8704 0 -1 0 37376 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 1024 0 -1 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="61" owner="0" type="0" pos="19.5 -73 5.875" rot="1 0 0 0" scale="" transform="1 0 0 19.5 0 1 0 -73 0 0 1 5.875 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.375" />
                            <Vertex pos="0.5 0.5 -0.125" />
                            <Vertex pos="0.5 -0.5 0.375" />
                            <Vertex pos="0.5 -0.5 -0.125" />
                            <Vertex pos="-0.5 0.5 0.125" />
                            <Vertex pos="-0.5 0.5 -0.375" />
                            <Vertex pos="-0.5 -0.5 0.125" />
                            <Vertex pos="-0.5 -0.5 -0.375" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 -3200 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 3328 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1408 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -1280 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 -0.242536" album="" material="bm_tile05_C" texgens="1 0 0 -2304 0 -1 0 768 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970143 -0.242536" album="" material="bm_grid_blank4" texgens="-1 0 0 1408 0 -1 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="62" owner="0" type="0" pos="20.5 -73 6.25" rot="1 0 0 0" scale="" transform="1 0 0 20.5 0 1 0 -73 0 0 1 6.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 4.76837e-007" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 4.76837e-007" />
                            <Vertex pos="-0.5 0.5 0" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 -3200 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 3328 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1408 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -1280 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.447214 0 0.894427 -0.223607" album="" material="bm_tile05_C" texgens="1 0 0 -2304 0 -1 0 768 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.447214 0 -0.894427 -0.223607" album="" material="bm_grid_blank4" texgens="-1 0 0 1408 0 -1 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="63" owner="0" type="0" pos="15.5 -74 5.75" rot="1 0 0 0" scale="" transform="1 0 0 15.5 0 1 0 -74 0 0 1 5.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.25" />
                            <Vertex pos="0.5 0.5 -0.25" />
                            <Vertex pos="0.5 -0.5 0.25" />
                            <Vertex pos="0.5 -0.5 -0.25" />
                            <Vertex pos="-0.5 0.5 0.25" />
                            <Vertex pos="-0.5 0.5 -0.25" />
                            <Vertex pos="-0.5 -0.5 0.25" />
                            <Vertex pos="-0.5 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 -3200 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 3328 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_trim" texgens="1 0 0 -1280 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_friction_mud" texgens="1 0 0 7936 0 -1 0 37888 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 1408 0 -1 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="64" owner="0" type="0" pos="35 -73 6.75" rot="1 0 0 0" scale="" transform="1 0 0 35 0 1 0 -73 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 0.25" />
                            <Vertex pos="2 1 -0.25" />
                            <Vertex pos="2 -1 0.25" />
                            <Vertex pos="2 -1 -0.25" />
                            <Vertex pos="-2 1 0.25" />
                            <Vertex pos="-2 1 -0.25" />
                            <Vertex pos="-2 -1 0.25" />
                            <Vertex pos="-2 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -2176 0 0 -1 -480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 1920 0 0 -1 -480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 -480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 -480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile11_A" texgens="1 0 0 -512 0 -1 0 4352 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="65" owner="0" type="0" pos="30 -73 6.75" rot="1 0 0 0" scale="" transform="1 0 0 30 0 1 0 -73 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.5 0.25" />
                            <Vertex pos="3 0.5 -0.25" />
                            <Vertex pos="3 -0.5 0.25" />
                            <Vertex pos="3 -0.5 -0.25" />
                            <Vertex pos="-3 0.5 0.25" />
                            <Vertex pos="-3 0.5 -0.25" />
                            <Vertex pos="-3 -0.5 0.25" />
                            <Vertex pos="-3 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 -3200 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 3328 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_trim" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_trim" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile05_C" texgens="1 0 0 -1024 0 -1 0 768 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="66" owner="0" type="0" pos="-18 -64.5 10.25" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 -64.5 0 0 1 10.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.5 0.25" />
                            <Vertex pos="3 0.5 -0.25" />
                            <Vertex pos="3 -0.5 0.25" />
                            <Vertex pos="3 -0.5 -0.25" />
                            <Vertex pos="-3 0.5 0.25" />
                            <Vertex pos="-3 0.5 -0.25" />
                            <Vertex pos="-3 -0.5 0.25" />
                            <Vertex pos="-3 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 -3200 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 3328 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile05_C" texgens="1 0 0 -1024 0 -1 0 768 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="67" owner="0" type="0" pos="-18 -67.5 10.25" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 -67.5 0 0 1 10.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.5 0.25" />
                            <Vertex pos="3 0.5 -0.25" />
                            <Vertex pos="3 -0.5 0.25" />
                            <Vertex pos="3 -0.5 -0.25" />
                            <Vertex pos="-3 0.5 0.25" />
                            <Vertex pos="-3 0.5 -0.25" />
                            <Vertex pos="-3 -0.5 0.25" />
                            <Vertex pos="-3 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 -3200 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 3328 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile05_C" texgens="1 0 0 -1024 0 -1 0 768 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="68" owner="0" type="0" pos="-21.5 -64.5 10.375" rot="1 0 0 0" scale="" transform="1 0 0 -21.5 0 1 0 -64.5 0 0 1 10.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.125001" />
                            <Vertex pos="0.5 0.5 -0.375" />
                            <Vertex pos="0.5 -0.5 0.125001" />
                            <Vertex pos="0.5 -0.5 -0.375" />
                            <Vertex pos="-0.5 0.5 0.375001" />
                            <Vertex pos="-0.5 0.5 -0.125" />
                            <Vertex pos="-0.5 -0.5 0.375001" />
                            <Vertex pos="-0.5 -0.5 -0.125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 -3200 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 3328 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970143 -0.242537" album="" material="bm_tile05_C" texgens="1 0 0 256 0 -1 0 768 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.242536" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="69" owner="0" type="0" pos="-21.5 -67.5 10.375" rot="1 0 0 0" scale="" transform="1 0 0 -21.5 0 1 0 -67.5 0 0 1 10.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.125001" />
                            <Vertex pos="0.5 0.5 -0.375" />
                            <Vertex pos="0.5 -0.5 0.125001" />
                            <Vertex pos="0.5 -0.5 -0.375" />
                            <Vertex pos="-0.5 0.5 0.375001" />
                            <Vertex pos="-0.5 0.5 -0.125" />
                            <Vertex pos="-0.5 -0.5 0.375001" />
                            <Vertex pos="-0.5 -0.5 -0.125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 -3200 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 3328 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970143 -0.242537" album="" material="bm_tile05_C" texgens="1 0 0 256 0 -1 0 768 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.242536" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="70" owner="0" type="0" pos="-22.5 -64.5 10.75" rot="1 0 0 0" scale="" transform="1 0 0 -22.5 0 1 0 -64.5 0 0 1 10.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0" />
                            <Vertex pos="0.5 0.5 -0.500001" />
                            <Vertex pos="0.5 -0.5 0" />
                            <Vertex pos="0.5 -0.5 -0.500001" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -9.53674e-007" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -9.53674e-007" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 -3200 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 3328 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.447214 0 0.894427 -0.223607" album="" material="bm_tile05_C" texgens="1 0 0 256 0 -1 0 768 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.447214 0 -0.894427 -0.223608" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="71" owner="0" type="0" pos="-22.5 -67.5 10.75" rot="1 0 0 0" scale="" transform="1 0 0 -22.5 0 1 0 -67.5 0 0 1 10.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0" />
                            <Vertex pos="0.5 0.5 -0.500001" />
                            <Vertex pos="0.5 -0.5 0" />
                            <Vertex pos="0.5 -0.5 -0.500001" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -9.53674e-007" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -9.53674e-007" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 -3200 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 3328 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.447214 0 0.894427 -0.223607" album="" material="bm_tile05_C" texgens="1 0 0 256 0 -1 0 768 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.447214 0 -0.894427 -0.223608" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="72" owner="0" type="0" pos="-78 -66 -5.5" rot="1 0 0 0" scale="" transform="1 0 0 -78 0 1 0 -66 0 0 1 -5.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="9 3 16" />
                            <Vertex pos="9 3 -18" />
                            <Vertex pos="9 -3 16" />
                            <Vertex pos="9 -3 -18" />
                            <Vertex pos="-9 3 16" />
                            <Vertex pos="-9 3 -18" />
                            <Vertex pos="-9 -3 16" />
                            <Vertex pos="-9 -3 -18" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -9" album="" material="bm_grid_blank4" texgens="0 1 0 -896 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -9" album="" material="bm_grid_blank4" texgens="0 -1 0 640 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -896 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16" album="" material="bm_tile11_A" texgens="1 0 0 -1792 0 -1 0 1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -18" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="73" owner="0" type="0" pos="-62.5 -67.5 10.375" rot="1 0 0 0" scale="" transform="1 0 0 -62.5 0 1 0 -67.5 0 0 1 10.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.5 -0.5 0.125" />
                            <Vertex pos="-0.5 -0.5 -0.375" />
                            <Vertex pos="-0.5 0.5 0.125" />
                            <Vertex pos="-0.5 0.5 -0.375" />
                            <Vertex pos="0.5 -0.5 0.375" />
                            <Vertex pos="0.5 -0.5 -0.125" />
                            <Vertex pos="0.5 0.5 0.375" />
                            <Vertex pos="0.5 0.5 -0.125" />
                        </Vertices>
                        <Face id="0" plane="-1 -0 -0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -3200 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 3328 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 1 0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 0 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 -0.242536" album="" material="bm_tile05_C" texgens="-1 0 0 256 0 1 0 768 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970143 -0.242536" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 1 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="74" owner="0" type="0" pos="-62.5 -64.5 10.375" rot="1 0 0 0" scale="" transform="1 0 0 -62.5 0 1 0 -64.5 0 0 1 10.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.5 -0.5 0.125" />
                            <Vertex pos="-0.5 -0.5 -0.375" />
                            <Vertex pos="-0.5 0.5 0.125" />
                            <Vertex pos="-0.5 0.5 -0.375" />
                            <Vertex pos="0.5 -0.5 0.375" />
                            <Vertex pos="0.5 -0.5 -0.125" />
                            <Vertex pos="0.5 0.5 0.375" />
                            <Vertex pos="0.5 0.5 -0.125" />
                        </Vertices>
                        <Face id="0" plane="-1 -0 -0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -3200 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 3328 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 1 0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 0 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 -0.242536" album="" material="bm_tile05_C" texgens="-1 0 0 256 0 1 0 768 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970143 -0.242536" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 1 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="75" owner="0" type="0" pos="-61.5 -67.5 10.75" rot="1 0 0 0" scale="" transform="1 0 0 -61.5 0 1 0 -67.5 0 0 1 10.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.5 -0.5 -2.86102e-006" />
                            <Vertex pos="-0.5 -0.5 -0.499997" />
                            <Vertex pos="-0.5 0.5 -2.86102e-006" />
                            <Vertex pos="-0.5 0.5 -0.499997" />
                            <Vertex pos="0.5 -0.5 0.499997" />
                            <Vertex pos="0.5 -0.5 2.86102e-006" />
                            <Vertex pos="0.5 0.5 0.499997" />
                            <Vertex pos="0.5 0.5 2.86102e-006" />
                        </Vertices>
                        <Face id="0" plane="-1 -0 -0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -3200 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 3328 0 0 -1 127.999 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 1 0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 0 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.447214 0 0.894427 -0.223604" album="" material="bm_tile05_C" texgens="-1 0 0 256 0 1 0 768 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.447214 0 -0.894427 -0.223604" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 1 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="76" owner="0" type="0" pos="-61.5 -64.5 10.75" rot="1 0 0 0" scale="" transform="1 0 0 -61.5 0 1 0 -64.5 0 0 1 10.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.5 -0.5 -2.86102e-006" />
                            <Vertex pos="-0.5 -0.5 -0.499997" />
                            <Vertex pos="-0.5 0.5 -2.86102e-006" />
                            <Vertex pos="-0.5 0.5 -0.499997" />
                            <Vertex pos="0.5 -0.5 0.499997" />
                            <Vertex pos="0.5 -0.5 2.86102e-006" />
                            <Vertex pos="0.5 0.5 0.499997" />
                            <Vertex pos="0.5 0.5 2.86102e-006" />
                        </Vertices>
                        <Face id="0" plane="-1 -0 -0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -3200 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 3328 0 0 -1 127.999 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 1 0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 0 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.447214 0 0.894427 -0.223604" album="" material="bm_tile05_C" texgens="-1 0 0 256 0 1 0 768 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.447214 0 -0.894427 -0.223604" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 1 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="77" owner="0" type="0" pos="-66 -64.5 10.25" rot="1 0 0 0" scale="" transform="1 0 0 -66 0 1 0 -64.5 0 0 1 10.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.5 0.25" />
                            <Vertex pos="3 0.5 -0.25" />
                            <Vertex pos="3 -0.5 0.25" />
                            <Vertex pos="3 -0.5 -0.25" />
                            <Vertex pos="-3 0.5 0.25" />
                            <Vertex pos="-3 0.5 -0.25" />
                            <Vertex pos="-3 -0.5 0.25" />
                            <Vertex pos="-3 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 -3200 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 3328 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile05_C" texgens="1 0 0 -1024 0 -1 0 768 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="78" owner="0" type="0" pos="-66 -67.5 10.25" rot="1 0 0 0" scale="" transform="1 0 0 -66 0 1 0 -67.5 0 0 1 10.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.5 0.25" />
                            <Vertex pos="3 0.5 -0.25" />
                            <Vertex pos="3 -0.5 0.25" />
                            <Vertex pos="3 -0.5 -0.25" />
                            <Vertex pos="-3 0.5 0.25" />
                            <Vertex pos="-3 0.5 -0.25" />
                            <Vertex pos="-3 -0.5 0.25" />
                            <Vertex pos="-3 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 -3200 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 3328 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile05_C" texgens="1 0 0 -1024 0 -1 0 768 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="79" owner="0" type="0" pos="-88 -61 -5.5" rot="1 0 0 0" scale="" transform="1 0 0 -88 0 1 0 -61 0 0 1 -5.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 8 16" />
                            <Vertex pos="1 8 -18" />
                            <Vertex pos="1 -8 16" />
                            <Vertex pos="1 -8 -18" />
                            <Vertex pos="-1 8 16" />
                            <Vertex pos="-1 8 -18" />
                            <Vertex pos="-1 -8 16" />
                            <Vertex pos="-1 -8 -18" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8" album="" material="bm_grid_blank4" texgens="-1 0 0 -384 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16" album="" material="bm_tile11_A" texgens="1 0 0 256 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -18" album="" material="bm_grid_blank4" texgens="-1 0 0 -384 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="80" owner="0" type="0" pos="-88 -58 13.5" rot="1 0 0 0" scale="" transform="1 0 0 -88 0 1 0 -58 0 0 1 13.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 5 3" />
                            <Vertex pos="1 5 -3" />
                            <Vertex pos="1 -5 3" />
                            <Vertex pos="1 -5 -3" />
                            <Vertex pos="-1 5 3" />
                            <Vertex pos="-1 5 -3" />
                            <Vertex pos="-1 -5 3" />
                            <Vertex pos="-1 -5 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 -384 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -5" album="" material="bm_grid_blank4" texgens="-1 0 0 -384 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_tile11_A" texgens="1 0 0 256 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -384 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="81" owner="0" type="0" pos="-88 -61 32.5" rot="1 0 0 0" scale="" transform="1 0 0 -88 0 1 0 -61 0 0 1 32.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 8 16" />
                            <Vertex pos="1 8 -16" />
                            <Vertex pos="1 -8 16" />
                            <Vertex pos="1 -8 -16" />
                            <Vertex pos="-1 8 16" />
                            <Vertex pos="-1 8 -16" />
                            <Vertex pos="-1 -8 16" />
                            <Vertex pos="-1 -8 -16" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 1024 0 0 -1 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 -1280 0 0 -1 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8" album="" material="bm_grid_blank4" texgens="-1 0 0 -384 0 0 -1 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16" album="" material="bm_friction_grass" texgens="1 0 0 -22528 0 -1 0 15616 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -16" album="" material="bm_grid_blank4" texgens="-1 0 0 -384 0 -1 0 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="82" owner="0" type="0" pos="-93 -70 5.5" rot="1 0 0 0" scale="" transform="1 0 0 -93 0 1 0 -70 0 0 1 5.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 1 27" />
                            <Vertex pos="6 1 -29" />
                            <Vertex pos="6 -1 27" />
                            <Vertex pos="6 -1 -29" />
                            <Vertex pos="-6 1 27" />
                            <Vertex pos="-6 1 -29" />
                            <Vertex pos="-6 -1 27" />
                            <Vertex pos="-6 -1 -29" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 640 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 -896 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -512 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -27" album="" material="bm_tile11_A" texgens="1 0 0 -1024 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -29" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="83" owner="0" type="0" pos="-106 -61 -5.5" rot="1 0 0 0" scale="" transform="1 0 0 -106 0 1 0 -61 0 0 1 -5.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 8 16" />
                            <Vertex pos="1 8 -18" />
                            <Vertex pos="1 -8 16" />
                            <Vertex pos="1 -8 -18" />
                            <Vertex pos="-1 8 16" />
                            <Vertex pos="-1 8 -18" />
                            <Vertex pos="-1 -8 16" />
                            <Vertex pos="-1 -8 -18" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8" album="" material="bm_grid_blank4" texgens="-1 0 0 -384 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16" album="" material="bm_tile11_A" texgens="1 0 0 256 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -18" album="" material="bm_grid_blank4" texgens="-1 0 0 -384 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="84" owner="0" type="0" pos="-97 -52 2.5" rot="1 0 0 0" scale="" transform="1 0 0 -97 0 1 0 -52 0 0 1 2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="10 1 24" />
                            <Vertex pos="10 1 -26" />
                            <Vertex pos="10 -1 24" />
                            <Vertex pos="10 -1 -26" />
                            <Vertex pos="-10 1 24" />
                            <Vertex pos="-10 1 -26" />
                            <Vertex pos="-10 -1 24" />
                            <Vertex pos="-10 -1 -26" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -10" album="" material="bm_grid_blank4" texgens="0 1 0 640 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -10" album="" material="bm_grid_blank4" texgens="0 -1 0 -896 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -1024 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -24" album="" material="bm_tile11_A" texgens="1 0 0 -2048 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -26" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="85" owner="0" type="0" pos="-106 -56 21.5" rot="1 0 0 0" scale="" transform="1 0 0 -106 0 1 0 -56 0 0 1 21.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 5" />
                            <Vertex pos="1 3 -5" />
                            <Vertex pos="1 -3 5" />
                            <Vertex pos="1 -3 -5" />
                            <Vertex pos="-1 3 5" />
                            <Vertex pos="-1 3 -5" />
                            <Vertex pos="-1 -3 5" />
                            <Vertex pos="-1 -3 -5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 384 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 -640 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -384 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -5" album="" material="bm_tile11_A" texgens="1 0 0 256 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -5" album="" material="bm_grid_blank4" texgens="-1 0 0 -384 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="86" owner="0" type="0" pos="-106 -62 18.5" rot="1 0 0 0" scale="" transform="1 0 0 -106 0 1 0 -62 0 0 1 18.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 8" />
                            <Vertex pos="1 3 -8" />
                            <Vertex pos="1 -3 8" />
                            <Vertex pos="1 -3 -8" />
                            <Vertex pos="-1 3 8" />
                            <Vertex pos="-1 3 -8" />
                            <Vertex pos="-1 -3 8" />
                            <Vertex pos="-1 -3 -8" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 384 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 -640 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -384 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -8" album="" material="bm_tile11_A" texgens="1 0 0 256 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -8" album="" material="bm_grid_blank4" texgens="-1 0 0 -384 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="87" owner="0" type="0" pos="-110 -56 9.5" rot="1 0 0 0" scale="" transform="1 0 0 -110 0 1 0 -56 0 0 1 9.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 1" />
                            <Vertex pos="3 3 -1" />
                            <Vertex pos="3 -3 1" />
                            <Vertex pos="3 -3 -1" />
                            <Vertex pos="-3 3 1" />
                            <Vertex pos="-3 3 -1" />
                            <Vertex pos="-3 0.999996 1" />
                            <Vertex pos="-3 0.999996 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 -896 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 640 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.5547 -0.832051 -0 -0.832052" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile11_A" texgens="1 0 0 -256 0 -1 0 1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="88" owner="0" type="0" pos="-116 -54 9.5" rot="1 0 0 0" scale="" transform="1 0 0 -116 0 1 0 -54 0 0 1 9.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 1 1" />
                            <Vertex pos="3 1 -1" />
                            <Vertex pos="3 -1 1" />
                            <Vertex pos="3 -1 -1" />
                            <Vertex pos="-3 1 1" />
                            <Vertex pos="-3 1 -1" />
                            <Vertex pos="-3 -1 1" />
                            <Vertex pos="-3 -1 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 -640 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 384 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile11_A" texgens="1 0 0 -256 0 -1 0 1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="89" owner="0" type="0" pos="-118 -57.5 10.25" rot="1 0 0 0" scale="" transform="1 0 0 -118 0 1 0 -57.5 0 0 1 10.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 2.5 0.25" />
                            <Vertex pos="0.5 2.5 -0.25" />
                            <Vertex pos="0.5 -2.5 0.25" />
                            <Vertex pos="0.5 -2.5 -0.25" />
                            <Vertex pos="-0.5 2.5 0.25" />
                            <Vertex pos="-0.5 2.5 -0.25" />
                            <Vertex pos="-0.5 -2.5 0.25" />
                            <Vertex pos="-0.5 -2.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 -3456 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 3584 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.5" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2.5" album="" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile05_C" texgens="1 0 0 256 0 -1 0 1280 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="90" owner="0" type="0" pos="-118 -63 16.25" rot="1 0 0 0" scale="" transform="1 0 0 -118 0 1 0 -63 0 0 1 16.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 2 0.25" />
                            <Vertex pos="0.5 2 -0.25" />
                            <Vertex pos="0.5 -2 0.25" />
                            <Vertex pos="0.5 -2 -0.25" />
                            <Vertex pos="-0.5 2 0.25" />
                            <Vertex pos="-0.5 2 -0.25" />
                            <Vertex pos="-0.5 -2 0.25" />
                            <Vertex pos="-0.5 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 -3328 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 3456 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile05_C" texgens="1 0 0 256 0 -1 0 1024 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="91" owner="0" type="0" pos="-118 -60.5 13.25" rot="1 0 0 0" scale="" transform="1 0 0 -118 0 1 0 -60.5 0 0 1 13.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 3.25" />
                            <Vertex pos="0.5 0.5 -3.25" />
                            <Vertex pos="0.5 -0.5 3.25" />
                            <Vertex pos="0.5 -0.5 -3.25" />
                            <Vertex pos="-0.5 0.5 3.25" />
                            <Vertex pos="-0.5 0.5 -3.25" />
                            <Vertex pos="-0.5 -0.5 3.25" />
                            <Vertex pos="-0.5 -0.5 -3.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 -3712 0 0 -1 832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 3840 0 0 -1 832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_beam" texgens="-1 0 0 128 0 0 -1 832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_beam" texgens="1 0 0 128 0 0 -1 832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3.25" album="" material="bm_tile05_C" texgens="1 0 0 256 0 -1 0 1792 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3.25" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="92" owner="0" type="0" pos="-116 -66 15.5" rot="1 0 0 0" scale="" transform="1 0 0 -116 0 1 0 -66 0 0 1 15.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 1 1" />
                            <Vertex pos="3 1 -1" />
                            <Vertex pos="3 -1 1" />
                            <Vertex pos="3 -1 -1" />
                            <Vertex pos="-3 1 1" />
                            <Vertex pos="-3 1 -1" />
                            <Vertex pos="-3 -1 1" />
                            <Vertex pos="-3 -1 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 -640 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 384 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile11_A" texgens="1 0 0 -256 0 -1 0 1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="93" owner="0" type="0" pos="-106 -68 18.5" rot="1 0 0 0" scale="" transform="1 0 0 -106 0 1 0 -68 0 0 1 18.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 8" />
                            <Vertex pos="1 1 -8" />
                            <Vertex pos="1 -1 8" />
                            <Vertex pos="1 -1 -8" />
                            <Vertex pos="-1 1 8" />
                            <Vertex pos="-1 1 -8" />
                            <Vertex pos="-1 -1 8" />
                            <Vertex pos="-1 -1 -8" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 640 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 -896 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -384 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -8" album="" material="bm_tile11_A" texgens="1 0 0 256 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -8" album="" material="bm_grid_blank4" texgens="-1 0 0 -384 0 -1 0 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="94" owner="0" type="0" pos="-106 -66 13.5" rot="1 0 0 0" scale="" transform="1 0 0 -106 0 1 0 -66 0 0 1 13.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 3" />
                            <Vertex pos="1 1 -3" />
                            <Vertex pos="1 -1 3" />
                            <Vertex pos="1 -1 -3" />
                            <Vertex pos="-1 1 3" />
                            <Vertex pos="-1 1 -3" />
                            <Vertex pos="-1 -1 3" />
                            <Vertex pos="-1 -1 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 640 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 -896 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -384 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_tile11_A" texgens="1 0 0 256 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -384 0 -1 0 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="95" owner="0" type="0" pos="-104 -70 2.5" rot="1 0 0 0" scale="" transform="1 0 0 -104 0 1 0 -70 0 0 1 2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 1 24" />
                            <Vertex pos="3 1 -26" />
                            <Vertex pos="3 -1 24" />
                            <Vertex pos="3 -1 -26" />
                            <Vertex pos="-3 1 24" />
                            <Vertex pos="-3 1 -26" />
                            <Vertex pos="-3 -1 24" />
                            <Vertex pos="-3 -1 -26" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 640 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 -896 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -24" album="" material="bm_tile11_A" texgens="1 0 0 -256 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -26" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="96" owner="0" type="0" pos="-100 -70 -2.5" rot="1 0 0 0" scale="" transform="1 0 0 -100 0 1 0 -70 0 0 1 -2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 19" />
                            <Vertex pos="1 1 -21" />
                            <Vertex pos="1 -1 19" />
                            <Vertex pos="1 -1 -21" />
                            <Vertex pos="-1 1 19" />
                            <Vertex pos="-1 1 -21" />
                            <Vertex pos="-1 -1 19" />
                            <Vertex pos="-1 -1 -21" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 640 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 -896 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -384 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -19" album="" material="bm_tile11_A" texgens="1 0 0 256 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -21" album="" material="bm_grid_blank4" texgens="-1 0 0 -384 0 -1 0 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="97" owner="0" type="0" pos="-102 -66 16.25" rot="1 0 0 0" scale="" transform="1 0 0 -102 0 1 0 -66 0 0 1 16.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.5 0.5 0.25" />
                            <Vertex pos="2.5 0.5 -0.25" />
                            <Vertex pos="2.5 -0.5 0.25" />
                            <Vertex pos="2.5 -0.5 -0.25" />
                            <Vertex pos="-2.5 0.5 0.25" />
                            <Vertex pos="-2.5 0.5 -0.25" />
                            <Vertex pos="-2.5 -0.5 0.25" />
                            <Vertex pos="-2.5 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2.5" album="" material="bm_edge_white" texgens="0 1 0 -3200 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.5" album="" material="bm_edge_white" texgens="0 -1 0 3328 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile05_C" texgens="1 0 0 -1280 0 -1 0 768 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 896 0 -1 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="98" owner="0" type="0" pos="-100 -67.5 16.25" rot="1 0 0 0" scale="" transform="1 0 0 -100 0 1 0 -67.5 0 0 1 16.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 1 0.25" />
                            <Vertex pos="0.5 1 -0.25" />
                            <Vertex pos="0.5 -1 0.25" />
                            <Vertex pos="0.5 -1 -0.25" />
                            <Vertex pos="-0.5 1 0.25" />
                            <Vertex pos="-0.5 1 -0.25" />
                            <Vertex pos="-0.5 -1 0.25" />
                            <Vertex pos="-0.5 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 -3328 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 3456 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 -256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile05_C" texgens="1 0 0 -256 0 -1 0 1024 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="99" owner="0" type="0" pos="-106 -66 22.5" rot="1 0 0 0" scale="" transform="1 0 0 -106 0 1 0 -66 0 0 1 22.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 4" />
                            <Vertex pos="1 1 -4" />
                            <Vertex pos="1 -1 4" />
                            <Vertex pos="1 -1 -4" />
                            <Vertex pos="-1 1 4" />
                            <Vertex pos="-1 1 -4" />
                            <Vertex pos="-1 -1 4" />
                            <Vertex pos="-1 -1 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 640 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 -896 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -384 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_tile11_A" texgens="1 0 0 256 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -384 0 -1 0 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="100" owner="0" type="0" pos="-100 -70 22.5" rot="1 0 0 0" scale="" transform="1 0 0 -100 0 1 0 -70 0 0 1 22.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 4" />
                            <Vertex pos="1 1 -4" />
                            <Vertex pos="1 -1 4" />
                            <Vertex pos="1 -1 -4" />
                            <Vertex pos="-1 1 4" />
                            <Vertex pos="-1 1 -4" />
                            <Vertex pos="-1 -1 4" />
                            <Vertex pos="-1 -1 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 640 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 -896 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -384 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_tile11_A" texgens="1 0 0 256 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -384 0 -1 0 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="101" owner="0" type="0" pos="-95 -74 15.5" rot="1 0 0 0" scale="" transform="1 0 0 -95 0 1 0 -74 0 0 1 15.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 3 1" />
                            <Vertex pos="6 3 -1" />
                            <Vertex pos="6 -3 1" />
                            <Vertex pos="6 -3 -1" />
                            <Vertex pos="-6 3 1" />
                            <Vertex pos="-6 3 -1" />
                            <Vertex pos="-6 -3 1" />
                            <Vertex pos="-6 -3 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 -896 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 640 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 256 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile11_A" texgens="1 0 0 512 0 -1 0 1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="102" owner="0" type="0" pos="-99 -74 25.5" rot="1 0 0 0" scale="" transform="1 0 0 -99 0 1 0 -74 0 0 1 25.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 3 1" />
                            <Vertex pos="6 3 -1" />
                            <Vertex pos="6 -3 1" />
                            <Vertex pos="6 -3 -1" />
                            <Vertex pos="-6 3 1" />
                            <Vertex pos="-6 3 -1" />
                            <Vertex pos="-6 -3 1" />
                            <Vertex pos="-6 -3 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 -896 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 640 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 256 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile11_A" texgens="1 0 0 512 0 -1 0 1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="103" owner="0" type="0" pos="-102 -45 25.5" rot="1 0 0 0" scale="" transform="1 0 0 -102 0 1 0 -45 0 0 1 25.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 6 1" />
                            <Vertex pos="3 6 -1" />
                            <Vertex pos="3 -6 1" />
                            <Vertex pos="3 -6 -1" />
                            <Vertex pos="-3 6 1" />
                            <Vertex pos="-3 6 -1" />
                            <Vertex pos="-3 -6 1" />
                            <Vertex pos="-3 -6 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 -512 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile11_A" texgens="1 0 0 -256 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="104" owner="0" type="0" pos="-97 -70 40.5" rot="1 0 0 0" scale="" transform="1 0 0 -97 0 1 0 -70 0 0 1 40.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="10 1 8" />
                            <Vertex pos="10 1 -8" />
                            <Vertex pos="10 -1 8" />
                            <Vertex pos="10 -1 -8" />
                            <Vertex pos="-10 1 8" />
                            <Vertex pos="-10 1 -8" />
                            <Vertex pos="-10 -1 8" />
                            <Vertex pos="-10 -1 -8" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -10" album="" material="bm_grid_blank4" texgens="0 1 0 640 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -10" album="" material="bm_grid_blank4" texgens="0 -1 0 -896 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 512 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -8" album="" material="bm_friction_grass" texgens="1 0 0 -24832 0 -1 0 17920 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -8" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="105" owner="0" type="0" pos="-106 -70 29.5" rot="1 0 0 0" scale="" transform="1 0 0 -106 0 1 0 -70 0 0 1 29.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 3" />
                            <Vertex pos="1 1 -3" />
                            <Vertex pos="1 -1 3" />
                            <Vertex pos="1 -1 -3" />
                            <Vertex pos="-1 1 3" />
                            <Vertex pos="-1 1 -3" />
                            <Vertex pos="-1 -1 3" />
                            <Vertex pos="-1 -1 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 640 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 -896 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -384 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_tile11_A" texgens="1 0 0 256 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -384 0 -1 0 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="106" owner="0" type="0" pos="-106 -61 37.5" rot="1 0 0 0" scale="" transform="1 0 0 -106 0 1 0 -61 0 0 1 37.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 8 11" />
                            <Vertex pos="1 8 -11" />
                            <Vertex pos="1 -8 11" />
                            <Vertex pos="1 -8 -11" />
                            <Vertex pos="-1 8 11" />
                            <Vertex pos="-1 8 -11" />
                            <Vertex pos="-1 -8 11" />
                            <Vertex pos="-1 -8 -11" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 -1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 -1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8" album="" material="bm_grid_blank4" texgens="-1 0 0 -384 0 0 -1 -1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 -1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -11" album="" material="bm_friction_grass" texgens="1 0 0 -27136 0 -1 0 15616 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -11" album="" material="bm_grid_blank4" texgens="-1 0 0 -384 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="107" owner="0" type="0" pos="-106 -52 29.5" rot="1 0 0 0" scale="" transform="1 0 0 -106 0 1 0 -52 0 0 1 29.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 3" />
                            <Vertex pos="1 1 -3" />
                            <Vertex pos="1 -1 3" />
                            <Vertex pos="1 -1 -3" />
                            <Vertex pos="-1 1 3" />
                            <Vertex pos="-1 1 -3" />
                            <Vertex pos="-1 -1 3" />
                            <Vertex pos="-1 -1 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 640 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 -896 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -384 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_tile11_A" texgens="1 0 0 256 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -384 0 -1 0 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="108" owner="0" type="0" pos="-97 -52 40.5" rot="1 0 0 0" scale="" transform="1 0 0 -97 0 1 0 -52 0 0 1 40.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="10 1 8" />
                            <Vertex pos="10 1 -8" />
                            <Vertex pos="10 -1 8" />
                            <Vertex pos="10 -1 -8" />
                            <Vertex pos="-10 1 8" />
                            <Vertex pos="-10 1 -8" />
                            <Vertex pos="-10 -1 8" />
                            <Vertex pos="-10 -1 -8" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -10" album="" material="bm_grid_blank4" texgens="0 1 0 640 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -10" album="" material="bm_grid_blank4" texgens="0 -1 0 -896 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -1536 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 1280 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -8" album="" material="bm_friction_grass" texgens="1 0 0 -24832 0 -1 0 13312 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -8" album="" material="bm_grid_blank4" texgens="-1 0 0 -1536 0 -1 0 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="109" owner="0" type="0" pos="-93 -52 29.5" rot="1 0 0 0" scale="" transform="1 0 0 -93 0 1 0 -52 0 0 1 29.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 1 3" />
                            <Vertex pos="6 1 -3" />
                            <Vertex pos="6 -1 3" />
                            <Vertex pos="6 -1 -3" />
                            <Vertex pos="-6 1 3" />
                            <Vertex pos="-6 1 -3" />
                            <Vertex pos="-6 -1 3" />
                            <Vertex pos="-6 -1 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 640 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 -896 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_tile11_A" texgens="1 0 0 1536 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 -1 0 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="110" owner="0" type="0" pos="-102 12 9.5" rot="1 0 0 0" scale="" transform="1 0 0 -102 0 1 0 12 0 0 1 9.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 27" />
                            <Vertex pos="3 3 -33" />
                            <Vertex pos="3 -3 27" />
                            <Vertex pos="3 -3 -33" />
                            <Vertex pos="-3 3 27" />
                            <Vertex pos="-3 3 -33" />
                            <Vertex pos="-3 -3 27" />
                            <Vertex pos="-3 -3 -33" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 -896 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 640 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -27" album="" material="bm_tile11_A" texgens="1 0 0 -256 0 -1 0 1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -33" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="111" owner="0" type="0" pos="-97 -61 43.5" rot="1 0 0 0" scale="" transform="1 0 0 -97 0 1 0 -61 0 0 1 43.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8 8 5" />
                            <Vertex pos="8 8 -5" />
                            <Vertex pos="8 -8 5" />
                            <Vertex pos="8 -8 -5" />
                            <Vertex pos="-8 8 5" />
                            <Vertex pos="-8 8 -5" />
                            <Vertex pos="-8 -8 5" />
                            <Vertex pos="-8 -8 -5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -8" album="" material="bm_grid_blank4" texgens="0 1 0 1024 0 0 -1 -3456 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -8" album="" material="bm_grid_blank4" texgens="0 -1 0 -1280 0 0 -1 -3456 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 0 -1 -3456 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8" album="" material="bm_grid_blank4" texgens="1 0 0 -768 0 0 -1 -3456 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -5" album="" material="bm_friction_grass" texgens="1 0 0 -24832 0 -1 0 15616 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -5" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 -1 0 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="155" owner="0" type="0" pos="-102 -35.5 27.5" rot="1 0 0 0" scale="" transform="1 0 0 -102 0 1 0 -35.5 0 0 1 27.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.5 1.5" />
                            <Vertex pos="3 0.5 -0.499998" />
                            <Vertex pos="-3 0.5 1.5" />
                            <Vertex pos="-3 0.5 -0.499998" />
                            <Vertex pos="3 -0.5 0.5" />
                            <Vertex pos="3 -0.5 -1.5" />
                            <Vertex pos="-3 -0.5 0.5" />
                            <Vertex pos="-3 -0.5 -1.5" />
                        </Vertices>
                        <Face id="0" plane="0 1 -0 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 192 0 1 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="-1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 64 0 1 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="3" plane="0 -0.707107 0.707107 -0.707107" album="" material="bm_tile11_A" texgens="1 0 0 -256 0 -1 0 1664 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="4" plane="0 0.707107 -0.707106 -0.707105" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 1088 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="5" plane="0 -1 0 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 0 1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="156" owner="0" type="0" pos="-102 -36.5 26.625" rot="1 0 0 0" scale="" transform="1 0 0 -102 0 1 0 -36.5 0 0 1 26.625 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.5 1.375" />
                            <Vertex pos="3 0.5 -0.625" />
                            <Vertex pos="-3 0.5 1.375" />
                            <Vertex pos="-3 0.5 -0.625" />
                            <Vertex pos="3 -0.5 0.624998" />
                            <Vertex pos="3 -0.5 -1.375" />
                            <Vertex pos="-3 -0.5 0.624998" />
                            <Vertex pos="-3 -0.5 -1.375" />
                        </Vertices>
                        <Face id="0" plane="0 1 -0 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 0 1 -1008 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 64 0 0.75 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="-1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 192 0 0.75 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="3" plane="0 -0.600001 0.799999 -0.799998" album="" material="bm_tile11_A" texgens="1 0 0 -256 0 -1 0 1920 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="4" plane="0 0.6 -0.8 -0.8" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 1216 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="5" plane="0 -1 0 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 0 1 -1008 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="157" owner="0" type="0" pos="-102 -37.5 26" rot="1 0 0 0" scale="" transform="1 0 0 -102 0 1 0 -37.5 0 0 1 26 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.5 1.25" />
                            <Vertex pos="3 0.5 -0.750002" />
                            <Vertex pos="-3 0.5 1.25" />
                            <Vertex pos="-3 0.5 -0.750002" />
                            <Vertex pos="3 -0.499996 0.750002" />
                            <Vertex pos="3 -0.499996 -1.25" />
                            <Vertex pos="-3 -0.499996 0.750002" />
                            <Vertex pos="-3 -0.499996 -1.25" />
                        </Vertices>
                        <Face id="0" plane="0 1 -0 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 0 1 -1088 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 192 0 0.5 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="-1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 64 0 0.5 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="3" plane="0 -0.447214 0.894427 -0.894427" album="" material="bm_tile11_A" texgens="1 0 0 -256 0 -1 0 2176 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="4" plane="0 0.447214 -0.894427 -0.894429" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 1344 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="5" plane="0 -1 0 -0.499996" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 0 1 -1088 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="158" owner="0" type="0" pos="-102 -38.5 25.625" rot="1 0 0 0" scale="" transform="1 0 0 -102 0 1 0 -38.5 0 0 1 25.625 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 -0.5 0.875" />
                            <Vertex pos="3 -0.5 -1.125" />
                            <Vertex pos="-3 -0.5 0.875" />
                            <Vertex pos="-3 -0.5 -1.125" />
                            <Vertex pos="3 0.5 1.125" />
                            <Vertex pos="3 0.5 -0.875" />
                            <Vertex pos="-3 0.5 1.125" />
                            <Vertex pos="-3 0.5 -0.875" />
                        </Vertices>
                        <Face id="0" plane="0 -1 0 -0.5" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 -1168 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 64 0 0.25 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 0 -0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 192 0 0.25 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 -0.242536 0.970142 -0.970142" album="" material="bm_tile11_A" texgens="1 0 0 -256 0 -1 0 2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 0.242536 -0.970142 -0.970142" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 1472 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 1 -0 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 0 1 -1136 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="159" owner="0" type="0" pos="-105.25 -38.5 26.375" rot="1 0 0 0" scale="" transform="1 0 0 -105.25 0 1 0 -38.5 0 0 1 26.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.5 0.375" />
                            <Vertex pos="0.25 0.5 -0.125002" />
                            <Vertex pos="0.25 -0.5 0.125002" />
                            <Vertex pos="0.25 -0.5 -0.375" />
                            <Vertex pos="-0.25 0.5 0.375" />
                            <Vertex pos="-0.25 0.5 -0.125002" />
                            <Vertex pos="-0.25 -0.5 0.125002" />
                            <Vertex pos="-0.25 -0.5 -0.375" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -2304 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0.25 -1 64.0005 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242534 0.970143 -0.242537" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.242534 -0.970143 -0.242537" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="160" owner="0" type="0" pos="-105.25 -37.5 26.75" rot="1 0 0 0" scale="" transform="1 0 0 -105.25 0 1 0 -37.5 0 0 1 26.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.5 0.499998" />
                            <Vertex pos="0.25 0.5 0" />
                            <Vertex pos="0.25 -0.499996 0" />
                            <Vertex pos="0.25 -0.499996 -0.499998" />
                            <Vertex pos="-0.25 0.5 0.499998" />
                            <Vertex pos="-0.25 0.5 0" />
                            <Vertex pos="-0.25 -0.499996 0" />
                            <Vertex pos="-0.25 -0.499996 -0.499998" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -2304 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 0.000976563 0 0.5 -1 63.9995 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.499996" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447214 0.894427 -0.223605" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.447214 -0.894427 -0.223607" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="161" owner="0" type="0" pos="-105.25 -36.5 27.375" rot="1 0 0 0" scale="" transform="1 0 0 -105.25 0 1 0 -36.5 0 0 1 27.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.5 0.625" />
                            <Vertex pos="0.25 0.5 0.124998" />
                            <Vertex pos="0.25 -0.5 -0.125" />
                            <Vertex pos="0.25 -0.5 -0.625002" />
                            <Vertex pos="-0.25 0.5 0.625" />
                            <Vertex pos="-0.25 0.5 0.124998" />
                            <Vertex pos="-0.25 -0.5 -0.125" />
                            <Vertex pos="-0.25 -0.5 -0.625002" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -2304 0 0 -1 -224 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 128 0 0.75 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -224 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -224 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.6 0.8 -0.2" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.6 -0.8 -0.200002" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="162" owner="0" type="0" pos="-105.25 -35.5 28.25" rot="1 0 0 0" scale="" transform="1 0 0 -105.25 0 1 0 -35.5 0 0 1 28.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.5 0.749998" />
                            <Vertex pos="0.25 0.5 0.249998" />
                            <Vertex pos="0.25 -0.5 -0.25" />
                            <Vertex pos="0.25 -0.5 -0.75" />
                            <Vertex pos="-0.25 0.5 0.749998" />
                            <Vertex pos="-0.25 0.5 0.249998" />
                            <Vertex pos="-0.25 -0.5 -0.25" />
                            <Vertex pos="-0.25 -0.5 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -2304 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 128 0 1 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707106 0.707107 -0.176776" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.707106 -0.707107 -0.176778" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="163" owner="0" type="0" pos="-98.75 -38.5 26.375" rot="1 0 0 0" scale="" transform="1 0 0 -98.75 0 1 0 -38.5 0 0 1 26.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.5 0.375" />
                            <Vertex pos="0.25 0.5 -0.125002" />
                            <Vertex pos="0.25 -0.5 0.125002" />
                            <Vertex pos="0.25 -0.5 -0.375" />
                            <Vertex pos="-0.25 0.5 0.375" />
                            <Vertex pos="-0.25 0.5 -0.125002" />
                            <Vertex pos="-0.25 -0.5 0.125002" />
                            <Vertex pos="-0.25 -0.5 -0.375" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 0 0 0.25 -1 64.0005 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 2432 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242534 0.970143 -0.242537" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.242534 -0.970143 -0.242537" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="164" owner="0" type="0" pos="-98.75 -37.5 26.75" rot="1 0 0 0" scale="" transform="1 0 0 -98.75 0 1 0 -37.5 0 0 1 26.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.5 0.499998" />
                            <Vertex pos="0.25 0.5 0" />
                            <Vertex pos="0.25 -0.499996 0" />
                            <Vertex pos="0.25 -0.499996 -0.499998" />
                            <Vertex pos="-0.25 0.5 0.499998" />
                            <Vertex pos="-0.25 0.5 0" />
                            <Vertex pos="-0.25 -0.499996 0" />
                            <Vertex pos="-0.25 -0.499996 -0.499998" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 0 0 0.5 -1 63.9995 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 2432 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.499996" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447214 0.894427 -0.223605" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.447214 -0.894427 -0.223607" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="165" owner="0" type="0" pos="-98.75 -36.5 27.375" rot="1 0 0 0" scale="" transform="1 0 0 -98.75 0 1 0 -36.5 0 0 1 27.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.5 0.625" />
                            <Vertex pos="0.25 0.5 0.124998" />
                            <Vertex pos="0.25 -0.5 -0.125" />
                            <Vertex pos="0.25 -0.5 -0.625002" />
                            <Vertex pos="-0.25 0.5 0.625" />
                            <Vertex pos="-0.25 0.5 0.124998" />
                            <Vertex pos="-0.25 -0.5 -0.125" />
                            <Vertex pos="-0.25 -0.5 -0.625002" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 128 0 0.75 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 2432 0 0 -1 -224 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -224 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -224 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.6 0.8 -0.2" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.6 -0.8 -0.200002" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="166" owner="0" type="0" pos="-98.75 -35.5 28.25" rot="1 0 0 0" scale="" transform="1 0 0 -98.75 0 1 0 -35.5 0 0 1 28.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.5 0.749998" />
                            <Vertex pos="0.25 0.5 0.249998" />
                            <Vertex pos="0.25 -0.5 -0.25" />
                            <Vertex pos="0.25 -0.5 -0.75" />
                            <Vertex pos="-0.25 0.5 0.749998" />
                            <Vertex pos="-0.25 0.5 0.249998" />
                            <Vertex pos="-0.25 -0.5 -0.25" />
                            <Vertex pos="-0.25 -0.5 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 128 0 1 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 2432 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707106 0.707107 -0.176776" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.707106 -0.707107 -0.176778" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="167" owner="0" type="0" pos="-2.5625 -9.5 0.3125" rot="1 0 0 0" scale="" transform="1 0 0 -2.5625 0 1 0 -9.5 0 0 1 0.3125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.0625 0.5 0.1875" />
                            <Vertex pos="0.0625 0.5 -0.3125" />
                            <Vertex pos="0.0625 -0.5 0.1875" />
                            <Vertex pos="0.0625 -0.5 -0.3125" />
                            <Vertex pos="-0.0625 0.5 0.3125" />
                            <Vertex pos="-0.0625 0.5 -0.1875" />
                            <Vertex pos="-0.0625 -0.5 0.3125" />
                            <Vertex pos="-0.0625 -0.5 -0.1875" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.0625" album="" material="bm_wood" texgens="0 1 0 -2432 0 0 -1 -80 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.0625" album="" material="bm_wood" texgens="0 -1 0 2432 0 0 -1 -80 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_wood" texgens="-1 0 0 656 0 0 -1 -80 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_wood" texgens="1 0 0 -656 0 0 -1 -80 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -0.176777" album="" material="bm_wood" texgens="1 0 0 -656 0 -1 0 2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 0 -0.707107 -0.176777" album="" material="bm_wood" texgens="-1 0 0 656 0 -1 0 2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="168" owner="0" type="0" pos="-1.4375 -9.5 0.3125" rot="1 0 0 0" scale="" transform="1 0 0 -1.4375 0 1 0 -9.5 0 0 1 0.3125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.0625 0.5 0.3125" />
                            <Vertex pos="0.0625 0.5 -0.1875" />
                            <Vertex pos="0.0625 -0.5 0.3125" />
                            <Vertex pos="0.0625 -0.5 -0.1875" />
                            <Vertex pos="-0.0625 0.5 0.1875" />
                            <Vertex pos="-0.0625 0.5 -0.3125" />
                            <Vertex pos="-0.0625 -0.5 0.1875" />
                            <Vertex pos="-0.0625 -0.5 -0.3125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.0625" album="" material="bm_wood" texgens="0 1 0 -2432 0 0 -1 -79.9999 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.0625" album="" material="bm_wood" texgens="0 -1 0 2432 0 0 -1 -79.9999 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_wood" texgens="-1 0 0 368 0 0 -1 -79.9999 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_wood" texgens="1 0 0 -368 0 0 -1 -79.9999 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -0.176777" album="" material="bm_wood" texgens="1 0 0 -368 0 -1 0 2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -0.176777" album="" material="bm_wood" texgens="-1 0 0 368 0 -1 0 2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="169" owner="0" type="0" pos="-2.5625 -10.5 0.437499" rot="1 0 0 0" scale="" transform="1 0 0 -2.5625 0 1 0 -10.5 0 0 1 0.437499 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.0625 0.5 0.0625005" />
                            <Vertex pos="0.0625 0.5 -0.437501" />
                            <Vertex pos="0.0625 -0.5 0.312501" />
                            <Vertex pos="0.0625 -0.5 -0.187501" />
                            <Vertex pos="-0.0625 0.5 0.187501" />
                            <Vertex pos="-0.0625 0.5 -0.3125" />
                            <Vertex pos="-0.0625 -0.5 0.437501" />
                            <Vertex pos="-0.0625 -0.5 -0.0624999" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.0625" album="" material="bm_wood" texgens="0 1 0 -2688 0 0 -1 -112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.0625" album="" material="bm_wood" texgens="0 -1 0 2688 0 0 -1 -112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_wood" texgens="-1 0 0 656 0 0 -1 -112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_wood" texgens="1 0 0 -656 0 0 -1 -112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.696312 0.174077 0.696309 -0.174078" album="" material="bm_wood" texgens="1 0 0 -656 0 -1 0 2688 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.696314 -0.174077 -0.696308 -0.174077" album="" material="bm_wood" texgens="-1 0 0 656 0 -1 0 2688 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="170" owner="0" type="0" pos="-1.4375 -10.5 0.4375" rot="1 0 0 0" scale="" transform="1 0 0 -1.4375 0 1 0 -10.5 0 0 1 0.4375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.0625 0.5 0.1875" />
                            <Vertex pos="0.0625 0.5 -0.3125" />
                            <Vertex pos="0.0625 -0.5 0.4375" />
                            <Vertex pos="0.0625 -0.5 -0.0625" />
                            <Vertex pos="-0.0625 0.5 0.0625" />
                            <Vertex pos="-0.0625 0.5 -0.4375" />
                            <Vertex pos="-0.0625 -0.5 0.3125" />
                            <Vertex pos="-0.0625 -0.5 -0.1875" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.0625" album="" material="bm_wood" texgens="0 1 0 -2688 0 0 -1 -112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.0625" album="" material="bm_wood" texgens="0 -1 0 2688 0 0 -1 -112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_wood" texgens="-1 0 0 368 0 0 -1 -112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_wood" texgens="1 0 0 -368 0 0 -1 -112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.696311 0.174078 0.696311 -0.174078" album="" material="bm_wood" texgens="1 0 0 -368 0 -1 0 2688 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.696311 -0.174078 -0.696311 -0.174078" album="" material="bm_wood" texgens="-1 0 0 368 0 -1 0 2688 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="171" owner="0" type="0" pos="-2.5625 -19.5 4.1875" rot="1 0 0 0" scale="" transform="1 0 0 -2.5625 0 1 0 -19.5 0 0 1 4.1875 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.0625 0.5 0.0625" />
                            <Vertex pos="0.0625 0.5 -0.4375" />
                            <Vertex pos="0.0625 -0.5 0.3125" />
                            <Vertex pos="0.0625 -0.5 -0.1875" />
                            <Vertex pos="-0.0625 0.5 0.1875" />
                            <Vertex pos="-0.0625 0.5 -0.3125" />
                            <Vertex pos="-0.0625 -0.5 0.4375" />
                            <Vertex pos="-0.0625 -0.5 -0.0625" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.0625" album="" material="bm_wood" texgens="0 1 0 -4992 0 0 -1 -1072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.0625" album="" material="bm_wood" texgens="0 -1 0 4992 0 0 -1 -1072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_wood" texgens="-1 0 0 656 0 0 -1 -1072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_wood" texgens="1 0 0 -656 0 0 -1 -1072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.696311 0.174078 0.696311 -0.174078" album="" material="bm_wood" texgens="1 0 0 -656 0 -1 0 4992 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.696311 -0.174078 -0.696311 -0.174078" album="" material="bm_wood" texgens="-1 0 0 656 0 -1 0 4992 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="172" owner="0" type="0" pos="-1.4375 -19.5 4.1875" rot="1 0 0 0" scale="" transform="1 0 0 -1.4375 0 1 0 -19.5 0 0 1 4.1875 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.0625 0.5 0.1875" />
                            <Vertex pos="0.0625 0.5 -0.3125" />
                            <Vertex pos="0.0625 -0.5 0.4375" />
                            <Vertex pos="0.0625 -0.5 -0.0625005" />
                            <Vertex pos="-0.0625 0.5 0.0625" />
                            <Vertex pos="-0.0625 0.5 -0.4375" />
                            <Vertex pos="-0.0625 -0.5 0.3125" />
                            <Vertex pos="-0.0625 -0.5 -0.1875" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.0625" album="" material="bm_wood" texgens="0 1 0 -4992 0 0 -1 -1072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.0625" album="" material="bm_wood" texgens="0 -1 0 4992 0 0 -1 -1072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_wood" texgens="-1 0 0 368 0 0 -1 -1072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_wood" texgens="1 0 0 -368 0 0 -1 -1072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.696311 0.174078 0.696311 -0.174078" album="" material="bm_wood" texgens="1 0 0 -368 0 -1 0 4992 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.696309 -0.174078 -0.696312 -0.174078" album="" material="bm_wood" texgens="-1 0 0 368 0 -1 0 4992 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="173" owner="0" type="0" pos="-2.5625 -20.5 4.3125" rot="1 0 0 0" scale="" transform="1 0 0 -2.5625 0 1 0 -20.5 0 0 1 4.3125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.0625 0.5 0.1875" />
                            <Vertex pos="0.0625 0.5 -0.3125" />
                            <Vertex pos="0.0625 -0.5 0.1875" />
                            <Vertex pos="0.0625 -0.5 -0.3125" />
                            <Vertex pos="-0.0625 0.5 0.3125" />
                            <Vertex pos="-0.0625 0.5 -0.1875" />
                            <Vertex pos="-0.0625 -0.5 0.3125" />
                            <Vertex pos="-0.0625 -0.5 -0.1875" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.0625" album="" material="bm_wood" texgens="0 1 0 -5248 0 0 -1 -1104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.0625" album="" material="bm_wood" texgens="0 -1 0 5248 0 0 -1 -1104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_wood" texgens="-1 0 0 656 0 0 -1 -1104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_wood" texgens="1 0 0 -656 0 0 -1 -1104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -0.176777" album="" material="bm_wood" texgens="1 0 0 -656 0 -1 0 5248 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 0 -0.707107 -0.176777" album="" material="bm_wood" texgens="-1 0 0 656 0 -1 0 5248 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="174" owner="0" type="0" pos="-1.4375 -20.5 4.3125" rot="1 0 0 0" scale="" transform="1 0 0 -1.4375 0 1 0 -20.5 0 0 1 4.3125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.0625 0.5 0.3125" />
                            <Vertex pos="0.0625 0.5 -0.1875" />
                            <Vertex pos="0.0625 -0.5 0.3125" />
                            <Vertex pos="0.0625 -0.5 -0.1875" />
                            <Vertex pos="-0.0625 0.5 0.1875" />
                            <Vertex pos="-0.0625 0.5 -0.3125" />
                            <Vertex pos="-0.0625 -0.5 0.1875" />
                            <Vertex pos="-0.0625 -0.5 -0.3125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.0625" album="" material="bm_wood" texgens="0 1 0 -5248 0 0 -1 -1104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.0625" album="" material="bm_wood" texgens="0 -1 0 5248 0 0 -1 -1104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_wood" texgens="-1 0 0 368 0 0 -1 -1104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_wood" texgens="1 0 0 -368 0 0 -1 -1104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -0.176777" album="" material="bm_wood" texgens="1 0 0 -368 0 -1 0 5248 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -0.176777" album="" material="bm_wood" texgens="-1 0 0 368 0 -1 0 5248 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="175" owner="0" type="0" pos="-2.5625 -15 2.3125" rot="1 0 0 0" scale="" transform="1 0 0 -2.5625 0 1 0 -15 0 0 1 2.3125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.0625 4 -1.5625" />
                            <Vertex pos="0.0625 4 -2.0625" />
                            <Vertex pos="0.0625 -4 1.9375" />
                            <Vertex pos="0.0625 -4 1.4375" />
                            <Vertex pos="-0.0625 4 -1.4375" />
                            <Vertex pos="-0.0625 4 -1.9375" />
                            <Vertex pos="-0.0625 -4 2.0625" />
                            <Vertex pos="-0.0625 -4 1.5625" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.0625" album="" material="bm_wood" texgens="0 1 0 -3840 0 0 -1 -592 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.0625" album="" material="bm_wood" texgens="0 -1 0 3840 0 0 -1 -592 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_wood" texgens="-1 0 0 656 0 0 -1 -592 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_wood" texgens="1 0 0 -656 0 0 -1 -592 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.675521 0.29554 0.675521 -0.16888" album="" material="bm_wood" texgens="1 0 0 -656 0 -1 0 3840 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.675521 -0.29554 -0.675521 -0.16888" album="" material="bm_wood" texgens="-1 0 0 656 0 -1 0 3840 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="176" owner="0" type="0" pos="-1.4375 -15 2.3125" rot="1 0 0 0" scale="" transform="1 0 0 -1.4375 0 1 0 -15 0 0 1 2.3125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.0625 4 -1.4375" />
                            <Vertex pos="0.0625 4 -1.9375" />
                            <Vertex pos="0.0625 -4 2.0625" />
                            <Vertex pos="0.0625 -4 1.5625" />
                            <Vertex pos="-0.0625 4 -1.5625" />
                            <Vertex pos="-0.0625 4 -2.0625" />
                            <Vertex pos="-0.0625 -4 1.9375" />
                            <Vertex pos="-0.0625 -4 1.4375" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.0625" album="" material="bm_wood" texgens="0 1 0 -3840 0 0 -1 -592 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.0625" album="" material="bm_wood" texgens="0 -1 0 3840 0 0 -1 -592 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_wood" texgens="-1 0 0 368 0 0 -1 -592 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_wood" texgens="1 0 0 -368 0 0 -1 -592 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.675521 0.29554 0.675521 -0.16888" album="" material="bm_wood" texgens="1 0 0 -368 0 -1 0 3840 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.675521 -0.29554 -0.675521 -0.16888" album="" material="bm_wood" texgens="-1 0 0 368 0 -1 0 3840 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="177" owner="0" type="0" pos="1.4375 -9.5 0.3125" rot="1 0 0 0" scale="" transform="1 0 0 1.4375 0 1 0 -9.5 0 0 1 0.3125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.0625 0.5 0.1875" />
                            <Vertex pos="0.0625 0.5 -0.3125" />
                            <Vertex pos="0.0625 -0.5 0.1875" />
                            <Vertex pos="0.0625 -0.5 -0.3125" />
                            <Vertex pos="-0.0625 0.5 0.3125" />
                            <Vertex pos="-0.0625 0.5 -0.1875" />
                            <Vertex pos="-0.0625 -0.5 0.3125" />
                            <Vertex pos="-0.0625 -0.5 -0.1875" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.0625" album="" material="bm_wood" texgens="0 1 0 -2432 0 0 -1 -79.9999 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.0625" album="" material="bm_wood" texgens="0 -1 0 2432 0 0 -1 -79.9999 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_wood" texgens="-1 0 0 -368 0 0 -1 -79.9999 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_wood" texgens="1 0 0 368 0 0 -1 -79.9999 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -0.176777" album="" material="bm_wood" texgens="1 0 0 368 0 -1 0 2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 0 -0.707107 -0.176777" album="" material="bm_wood" texgens="-1 0 0 -368 0 -1 0 2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="178" owner="0" type="0" pos="2.5625 -9.5 0.3125" rot="1 0 0 0" scale="" transform="1 0 0 2.5625 0 1 0 -9.5 0 0 1 0.3125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.0625 0.5 0.3125" />
                            <Vertex pos="0.0625 0.5 -0.1875" />
                            <Vertex pos="0.0625 -0.5 0.3125" />
                            <Vertex pos="0.0625 -0.5 -0.1875" />
                            <Vertex pos="-0.0625 0.5 0.1875" />
                            <Vertex pos="-0.0625 0.5 -0.3125" />
                            <Vertex pos="-0.0625 -0.5 0.1875" />
                            <Vertex pos="-0.0625 -0.5 -0.3125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.0625" album="" material="bm_wood" texgens="0 1 0 -2432 0 0 -1 -80 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.0625" album="" material="bm_wood" texgens="0 -1 0 2432 0 0 -1 -80 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_wood" texgens="-1 0 0 -656 0 0 -1 -80 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_wood" texgens="1 0 0 656 0 0 -1 -80 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -0.176777" album="" material="bm_wood" texgens="1 0 0 656 0 -1 0 2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -0.176777" album="" material="bm_wood" texgens="-1 0 0 -656 0 -1 0 2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="179" owner="0" type="0" pos="1.4375 -10.5 0.4375" rot="1 0 0 0" scale="" transform="1 0 0 1.4375 0 1 0 -10.5 0 0 1 0.4375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.0625 0.5 0.0624999" />
                            <Vertex pos="0.0625 0.5 -0.4375" />
                            <Vertex pos="0.0625 -0.5 0.3125" />
                            <Vertex pos="0.0625 -0.5 -0.1875" />
                            <Vertex pos="-0.0625 0.5 0.1875" />
                            <Vertex pos="-0.0625 0.5 -0.3125" />
                            <Vertex pos="-0.0625 -0.5 0.4375" />
                            <Vertex pos="-0.0625 -0.5 -0.0625002" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.0625" album="" material="bm_wood" texgens="0 1 0 -2688 0 0 -1 -112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.0625" album="" material="bm_wood" texgens="0 -1 0 2688 0 0 -1 -112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_wood" texgens="-1 0 0 -368 0 0 -1 -112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_wood" texgens="1 0 0 368 0 0 -1 -112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.696311 0.174078 0.69631 -0.174078" album="" material="bm_wood" texgens="1 0 0 368 0 -1 0 2688 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.69631 -0.174078 -0.696311 -0.174078" album="" material="bm_wood" texgens="-1 0 0 -368 0 -1 0 2688 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="180" owner="0" type="0" pos="2.5625 -10.5 0.437499" rot="1 0 0 0" scale="" transform="1 0 0 2.5625 0 1 0 -10.5 0 0 1 0.437499 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.0625 0.5 0.187501" />
                            <Vertex pos="0.0625 0.5 -0.3125" />
                            <Vertex pos="0.0625 -0.5 0.437501" />
                            <Vertex pos="0.0625 -0.5 -0.0624991" />
                            <Vertex pos="-0.0625 0.5 0.0625006" />
                            <Vertex pos="-0.0625 0.5 -0.437501" />
                            <Vertex pos="-0.0625 -0.5 0.312501" />
                            <Vertex pos="-0.0625 -0.5 -0.1875" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.0625" album="" material="bm_wood" texgens="0 1 0 -2688 0 0 -1 -112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.0625" album="" material="bm_wood" texgens="0 -1 0 2688 0 0 -1 -112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_wood" texgens="-1 0 0 -656 0 0 -1 -112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_wood" texgens="1 0 0 656 0 0 -1 -112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.696312 0.174078 0.69631 -0.174078" album="" material="bm_wood" texgens="1 0 0 656 0 -1 0 2688 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.696313 -0.174078 -0.696308 -0.174077" album="" material="bm_wood" texgens="-1 0 0 -656 0 -1 0 2688 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="181" owner="0" type="0" pos="1.4375 -19.5 4.1875" rot="1 0 0 0" scale="" transform="1 0 0 1.4375 0 1 0 -19.5 0 0 1 4.1875 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.0625 0.5 0.0625" />
                            <Vertex pos="0.0625 0.5 -0.4375" />
                            <Vertex pos="0.0625 -0.5 0.3125" />
                            <Vertex pos="0.0625 -0.5 -0.1875" />
                            <Vertex pos="-0.0625 0.5 0.1875" />
                            <Vertex pos="-0.0625 0.5 -0.3125" />
                            <Vertex pos="-0.0625 -0.5 0.4375" />
                            <Vertex pos="-0.0625 -0.5 -0.0625" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.0625" album="" material="bm_wood" texgens="0 1 0 -4992 0 0 -1 -1072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.0625" album="" material="bm_wood" texgens="0 -1 0 4992 0 0 -1 -1072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_wood" texgens="-1 0 0 -368 0 0 -1 -1072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_wood" texgens="1 0 0 368 0 0 -1 -1072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.696311 0.174078 0.696311 -0.174078" album="" material="bm_wood" texgens="1 0 0 368 0 -1 0 4992 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.696311 -0.174078 -0.696311 -0.174078" album="" material="bm_wood" texgens="-1 0 0 -368 0 -1 0 4992 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="182" owner="0" type="0" pos="2.5625 -19.5 4.1875" rot="1 0 0 0" scale="" transform="1 0 0 2.5625 0 1 0 -19.5 0 0 1 4.1875 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.0625 0.5 0.1875" />
                            <Vertex pos="0.0625 0.5 -0.3125" />
                            <Vertex pos="0.0625 -0.5 0.4375" />
                            <Vertex pos="0.0625 -0.5 -0.0625" />
                            <Vertex pos="-0.0625 0.5 0.0625" />
                            <Vertex pos="-0.0625 0.5 -0.4375" />
                            <Vertex pos="-0.0625 -0.5 0.3125" />
                            <Vertex pos="-0.0625 -0.5 -0.1875" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.0625" album="" material="bm_wood" texgens="0 1 0 -4992 0 0 -1 -1072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.0625" album="" material="bm_wood" texgens="0 -1 0 4992 0 0 -1 -1072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_wood" texgens="-1 0 0 -656 0 0 -1 -1072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_wood" texgens="1 0 0 656 0 0 -1 -1072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.696311 0.174078 0.696311 -0.174078" album="" material="bm_wood" texgens="1 0 0 656 0 -1 0 4992 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.696311 -0.174078 -0.696311 -0.174078" album="" material="bm_wood" texgens="-1 0 0 -656 0 -1 0 4992 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="183" owner="0" type="0" pos="1.4375 -20.5 4.3125" rot="1 0 0 0" scale="" transform="1 0 0 1.4375 0 1 0 -20.5 0 0 1 4.3125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.0625 0.5 0.1875" />
                            <Vertex pos="0.0625 0.5 -0.3125" />
                            <Vertex pos="0.0625 -0.5 0.1875" />
                            <Vertex pos="0.0625 -0.5 -0.3125" />
                            <Vertex pos="-0.0625 0.5 0.3125" />
                            <Vertex pos="-0.0625 0.5 -0.1875" />
                            <Vertex pos="-0.0625 -0.5 0.3125" />
                            <Vertex pos="-0.0625 -0.5 -0.1875" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.0625" album="" material="bm_wood" texgens="0 1 0 -5248 0 0 -1 -1104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.0625" album="" material="bm_wood" texgens="0 -1 0 5248 0 0 -1 -1104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_wood" texgens="-1 0 0 -368 0 0 -1 -1104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_wood" texgens="1 0 0 368 0 0 -1 -1104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -0.176777" album="" material="bm_wood" texgens="1 0 0 368 0 -1 0 5248 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 0 -0.707107 -0.176777" album="" material="bm_wood" texgens="-1 0 0 -368 0 -1 0 5248 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="184" owner="0" type="0" pos="2.5625 -20.5 4.3125" rot="1 0 0 0" scale="" transform="1 0 0 2.5625 0 1 0 -20.5 0 0 1 4.3125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.0625 0.5 0.3125" />
                            <Vertex pos="0.0625 0.5 -0.1875" />
                            <Vertex pos="0.0625 -0.5 0.3125" />
                            <Vertex pos="0.0625 -0.5 -0.1875" />
                            <Vertex pos="-0.0625 0.5 0.1875" />
                            <Vertex pos="-0.0625 0.5 -0.3125" />
                            <Vertex pos="-0.0625 -0.5 0.1875" />
                            <Vertex pos="-0.0625 -0.5 -0.3125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.0625" album="" material="bm_wood" texgens="0 1 0 -5248 0 0 -1 -1104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.0625" album="" material="bm_wood" texgens="0 -1 0 5248 0 0 -1 -1104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_wood" texgens="-1 0 0 -656 0 0 -1 -1104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_wood" texgens="1 0 0 656 0 0 -1 -1104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -0.176777" album="" material="bm_wood" texgens="1 0 0 656 0 -1 0 5248 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -0.176777" album="" material="bm_wood" texgens="-1 0 0 -656 0 -1 0 5248 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="185" owner="0" type="0" pos="1.4375 -15 2.3125" rot="1 0 0 0" scale="" transform="1 0 0 1.4375 0 1 0 -15 0 0 1 2.3125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.0625 4 -1.5625" />
                            <Vertex pos="0.0625 4 -2.0625" />
                            <Vertex pos="0.0625 -4 1.9375" />
                            <Vertex pos="0.0625 -4 1.4375" />
                            <Vertex pos="-0.0625 4 -1.4375" />
                            <Vertex pos="-0.0625 4 -1.9375" />
                            <Vertex pos="-0.0625 -4 2.0625" />
                            <Vertex pos="-0.0625 -4 1.5625" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.0625" album="" material="bm_wood" texgens="0 1 0 -3840 0 0 -1 -592 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.0625" album="" material="bm_wood" texgens="0 -1 0 3840 0 0 -1 -592 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_wood" texgens="-1 0 0 -368 0 0 -1 -592 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_wood" texgens="1 0 0 368 0 0 -1 -592 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.675521 0.29554 0.675521 -0.16888" album="" material="bm_wood" texgens="1 0 0 368 0 -1 0 3840 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.675521 -0.29554 -0.675521 -0.16888" album="" material="bm_wood" texgens="-1 0 0 -368 0 -1 0 3840 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="186" owner="0" type="0" pos="2.5625 -15 2.3125" rot="1 0 0 0" scale="" transform="1 0 0 2.5625 0 1 0 -15 0 0 1 2.3125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.0625 4 -1.4375" />
                            <Vertex pos="0.0625 4 -1.9375" />
                            <Vertex pos="0.0625 -4 2.0625" />
                            <Vertex pos="0.0625 -4 1.5625" />
                            <Vertex pos="-0.0625 4 -1.5625" />
                            <Vertex pos="-0.0625 4 -2.0625" />
                            <Vertex pos="-0.0625 -4 1.9375" />
                            <Vertex pos="-0.0625 -4 1.4375" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.0625" album="" material="bm_wood" texgens="0 1 0 -3840 0 0 -1 -592 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.0625" album="" material="bm_wood" texgens="0 -1 0 3840 0 0 -1 -592 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_wood" texgens="-1 0 0 -656 0 0 -1 -592 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_wood" texgens="1 0 0 656 0 0 -1 -592 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.675521 0.29554 0.675521 -0.16888" album="" material="bm_wood" texgens="1 0 0 656 0 -1 0 3840 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.675521 -0.29554 -0.675521 -0.16888" album="" material="bm_wood" texgens="-1 0 0 -656 0 -1 0 3840 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="187" owner="0" type="0" pos="-2.5625 -35.5 4.3125" rot="1 0 0 0" scale="" transform="1 0 0 -2.5625 0 1 0 -35.5 0 0 1 4.3125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.0625 2.5 0.1875" />
                            <Vertex pos="0.0625 2.5 -0.3125" />
                            <Vertex pos="0.0625 -2.5 0.1875" />
                            <Vertex pos="0.0625 -2.5 -0.3125" />
                            <Vertex pos="-0.0625 2.5 0.3125" />
                            <Vertex pos="-0.0625 2.5 -0.1875" />
                            <Vertex pos="-0.0625 -2.375 0.3125" />
                            <Vertex pos="-0.0625 -2.375 -0.1875" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.0625" album="" material="bm_wood" texgens="0 1 0 -9088 0 0 -1 -1104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.0625" album="" material="bm_wood" texgens="0 -1 0 9088 0 0 -1 -1104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.5" album="" material="bm_wood" texgens="-1 0 0 656 0 0 -1 -1104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -1.72357" album="" material="bm_wood" texgens="1 0 0 -656 0 0 -1 -1104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -0.176777" album="" material="bm_wood" texgens="1 0 0 -656 0 -1 0 9088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 0 -0.707107 -0.176777" album="" material="bm_wood" texgens="-1 0 0 656 0 -1 0 9088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="188" owner="0" type="0" pos="-1.4375 -36.0625 4.3125" rot="1 0 0 0" scale="" transform="1 0 0 -1.4375 0 1 0 -36.0625 0 0 1 4.3125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.0625 3.0625 0.3125" />
                            <Vertex pos="0.0625 3.0625 -0.1875" />
                            <Vertex pos="0.0625 -3.0625 0.3125" />
                            <Vertex pos="0.0625 -3.0625 -0.1875" />
                            <Vertex pos="-0.0625 3.0625 0.1875" />
                            <Vertex pos="-0.0625 3.0625 -0.3125" />
                            <Vertex pos="-0.0625 -2.9375 0.1875" />
                            <Vertex pos="-0.0625 -2.9375 -0.3125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.0625" album="" material="bm_wood" texgens="0 1 0 -9232 0 0 -1 -1104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.0625" album="" material="bm_wood" texgens="0 -1 0 9232 0 0 -1 -1104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3.0625" album="" material="bm_wood" texgens="-1 0 0 368 0 0 -1 -1104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -2.12132" album="" material="bm_wood" texgens="1 0 0 -368 0 0 -1 -1104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -0.176777" album="" material="bm_wood" texgens="1 0 0 -368 0 -1 0 9232 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -0.176777" album="" material="bm_wood" texgens="-1 0 0 368 0 -1 0 9232 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="189" owner="0" type="0" pos="-3.5 -37.9375 4.3125" rot="1 0 0 0" scale="" transform="1 0 0 -3.5 0 1 0 -37.9375 0 0 1 4.3125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.875 0.0625 0.3125" />
                            <Vertex pos="0.875 0.0625 -0.1875" />
                            <Vertex pos="1 -0.0625 0.1875" />
                            <Vertex pos="1 -0.0625 -0.3125" />
                            <Vertex pos="-1 0.0625 0.3125" />
                            <Vertex pos="-1 0.0625 -0.1875" />
                            <Vertex pos="-1 -0.0625 0.1875" />
                            <Vertex pos="-1 -0.0625 -0.3125" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -0.662913" album="" material="bm_wood" texgens="0 1 0 -9712 0 0 -1 -1104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -1" album="" material="bm_wood" texgens="0 -1 0 9712 0 0 -1 -1104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 896 0 0 -1 -1104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 -896 0 0 -1 -1104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707107 -0.176777" album="" material="bm_wood" texgens="1 0 0 -896 0 -1 0 9712 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.707107 -0.707107 -0.176777" album="" material="bm_wood" texgens="-1 0 0 896 0 -1 0 9712 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="190" owner="0" type="0" pos="-2.9375 -39.0625 4.3125" rot="1 0 0 0" scale="" transform="1 0 0 -2.9375 0 1 0 -39.0625 0 0 1 4.3125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.4375 0.0625 0.187501" />
                            <Vertex pos="1.4375 0.0625 -0.312502" />
                            <Vertex pos="1.5625 -0.0625 0.312501" />
                            <Vertex pos="1.5625 -0.0625 -0.187501" />
                            <Vertex pos="-1.5625 0.0625 0.187501" />
                            <Vertex pos="-1.5625 0.0625 -0.312502" />
                            <Vertex pos="-1.5625 -0.0625 0.312501" />
                            <Vertex pos="-1.5625 -0.0625 -0.187501" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -1.06066" album="" material="bm_wood" texgens="0 1 0 -10000 0 0 -1 -1104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1.5625" album="" material="bm_wood" texgens="0 -1 0 10000 0 0 -1 -1104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 752 0 0 -1 -1104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 -752 0 0 -1 -1104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707107 -0.176777" album="" material="bm_wood" texgens="1 0 0 -752 0 -1 0 10000 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.70711 -0.707104 -0.176777" album="" material="bm_wood" texgens="-1 0 0 752 0 -1 0 10000 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="191" owner="0" type="0" pos="-6.5 -37.9375 3.8125" rot="1 0 0 0" scale="" transform="1 0 0 -6.5 0 1 0 -37.9375 0 0 1 3.8125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.0625 0.3125" />
                            <Vertex pos="1 0.0625 -0.1875" />
                            <Vertex pos="1 -0.0625 0.1875" />
                            <Vertex pos="1 -0.0625 -0.3125" />
                            <Vertex pos="-1 0.0625 0.3125" />
                            <Vertex pos="-1 0.0625 -0.1875" />
                            <Vertex pos="-1 -0.0625 0.1875" />
                            <Vertex pos="-1 -0.0625 -0.3125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_wood" texgens="0 1 0 -9712 0 0 -1 -976 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -1" album="" material="bm_wood" texgens="0 -1 0 9712 0 0 -1 -976 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 1664 0 0 -1 -976 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 -1664 0 0 -1 -976 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707107 -0.176777" album="" material="bm_wood" texgens="1 0 0 -1664 0 -1 0 9712 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.707107 -0.707107 -0.176777" album="" material="bm_wood" texgens="-1 0 0 1664 0 -1 0 9712 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="192" owner="0" type="0" pos="-6.5 -39.0625 3.8125" rot="1 0 0 0" scale="" transform="1 0 0 -6.5 0 1 0 -39.0625 0 0 1 3.8125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.0625 0.1875" />
                            <Vertex pos="1 0.0625 -0.3125" />
                            <Vertex pos="1 -0.0625 0.3125" />
                            <Vertex pos="1 -0.0625 -0.1875" />
                            <Vertex pos="-1 0.0625 0.1875" />
                            <Vertex pos="-1 0.0625 -0.3125" />
                            <Vertex pos="-1 -0.0625 0.3125" />
                            <Vertex pos="-1 -0.0625 -0.1875" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -1" album="" material="bm_wood" texgens="0 1 0 -10000 0 0 -1 -976 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_wood" texgens="0 -1 0 10000 0 0 -1 -976 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 1664 0 0 -1 -976 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 -1664 0 0 -1 -976 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707107 -0.176777" album="" material="bm_wood" texgens="1 0 0 -1664 0 -1 0 10000 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.707107 -0.707107 -0.176777" album="" material="bm_wood" texgens="-1 0 0 1664 0 -1 0 10000 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="193" owner="0" type="0" pos="-5 -37.9375 4.0625" rot="1 0 0 0" scale="" transform="1 0 0 -5 0 1 0 -37.9375 0 0 1 4.0625 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.0625 0.5625" />
                            <Vertex pos="0.5 0.0625 0.0625014" />
                            <Vertex pos="0.5 -0.0625 0.437499" />
                            <Vertex pos="0.5 -0.0625 -0.0624995" />
                            <Vertex pos="-0.5 0.0625 0.0624995" />
                            <Vertex pos="-0.5 0.0625 -0.437499" />
                            <Vertex pos="-0.5 -0.0625 -0.0625014" />
                            <Vertex pos="-0.5 -0.0625 -0.5625" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_wood" texgens="0 1 0 -9712 0 0 -1 -1040 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.5" album="" material="bm_wood" texgens="0 -1 0 9712 0 0 -1 -1040 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 1280 0 0 -1 -1040 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 -1280 0 0 -1 -1040 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.333333 -0.666669 0.666664 -0.166666" album="" material="bm_wood" texgens="1 0 0 -1280 0 -1 0 9712 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.333333 0.666669 -0.666664 -0.166666" album="" material="bm_wood" texgens="-1 0 0 1280 0 -1 0 9712 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="194" owner="0" type="0" pos="-5 -39.0625 4.0625" rot="1 0 0 0" scale="" transform="1 0 0 -5 0 1 0 -39.0625 0 0 1 4.0625 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.0625 0.4375" />
                            <Vertex pos="0.5 0.0625 -0.0625012" />
                            <Vertex pos="0.5 -0.0625 0.562501" />
                            <Vertex pos="0.5 -0.0625 0.0625" />
                            <Vertex pos="-0.5 0.0625 -0.0625002" />
                            <Vertex pos="-0.5 0.0625 -0.562501" />
                            <Vertex pos="-0.5 -0.0625 0.062501" />
                            <Vertex pos="-0.5 -0.0625 -0.4375" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.5" album="" material="bm_wood" texgens="0 1 0 -10000 0 0 -1 -1040 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_wood" texgens="0 -1 0 10000 0 0 -1 -1040 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 1280 0 0 -1 -1040 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 -1280 0 0 -1 -1040 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.333332 0.66667 0.666664 -0.166666" album="" material="bm_wood" texgens="1 0 0 -1280 0 -1 0 10000 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.333332 -0.66667 -0.666664 -0.166666" album="" material="bm_wood" texgens="-1 0 0 1280 0 -1 0 10000 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="195" owner="0" type="0" pos="-8 -37.9375 4.0625" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 -37.9375 0 0 1 4.0625 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.0625 0.0624995" />
                            <Vertex pos="0.5 0.0625 -0.437499" />
                            <Vertex pos="0.5 -0.0625 -0.0625014" />
                            <Vertex pos="0.5 -0.0625 -0.5625" />
                            <Vertex pos="-0.5 0.0625 0.5625" />
                            <Vertex pos="-0.5 0.0625 0.0625014" />
                            <Vertex pos="-0.5 -0.0625 0.437499" />
                            <Vertex pos="-0.5 -0.0625 -0.0624995" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_wood" texgens="0 1 0 -9712 0 0 -1 -1040 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.5" album="" material="bm_wood" texgens="0 -1 0 9712 0 0 -1 -1040 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 2048 0 0 -1 -1040 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 -2048 0 0 -1 -1040 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.333332 -0.66667 0.666664 -0.166666" album="" material="bm_wood" texgens="1 0 0 -2048 0 -1 0 9712 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.333332 0.66667 -0.666664 -0.166666" album="" material="bm_wood" texgens="-1 0 0 2048 0 -1 0 9712 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="196" owner="0" type="0" pos="-8 -39.0625 4.0625" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 -39.0625 0 0 1 4.0625 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.0625 -0.0625" />
                            <Vertex pos="0.5 0.0625 -0.562501" />
                            <Vertex pos="0.5 -0.0625 0.062501" />
                            <Vertex pos="0.5 -0.0625 -0.4375" />
                            <Vertex pos="-0.5 0.0625 0.4375" />
                            <Vertex pos="-0.5 0.0625 -0.062501" />
                            <Vertex pos="-0.5 -0.0625 0.562501" />
                            <Vertex pos="-0.5 -0.0625 0.0625" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.5" album="" material="bm_wood" texgens="0 1 0 -10000 0 0 -1 -1040 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_wood" texgens="0 -1 0 10000 0 0 -1 -1040 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 2048 0 0 -1 -1040 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 -2048 0 0 -1 -1040 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.333332 0.66667 0.666664 -0.166666" album="" material="bm_wood" texgens="1 0 0 -2048 0 -1 0 10000 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.333332 -0.66667 -0.666664 -0.166666" album="" material="bm_wood" texgens="-1 0 0 2048 0 -1 0 10000 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="197" owner="0" type="0" pos="-10.5625 -37.9375 4.3125" rot="1 0 0 0" scale="" transform="1 0 0 -10.5625 0 1 0 -37.9375 0 0 1 4.3125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.0625 0.0625 0.3125" />
                            <Vertex pos="2.0625 0.0625 -0.1875" />
                            <Vertex pos="2.0625 -0.0625 0.1875" />
                            <Vertex pos="2.0625 -0.0625 -0.3125" />
                            <Vertex pos="-2.0625 0.0625 0.3125" />
                            <Vertex pos="-2.0625 0.0625 -0.1875" />
                            <Vertex pos="-1.9375 -0.0625 0.1875" />
                            <Vertex pos="-1.9375 -0.0625 -0.3125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2.0625" album="" material="bm_wood" texgens="0 1 0 -9712 0 0 -1 -1104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -1.41421" album="" material="bm_wood" texgens="0 -1 0 9712 0 0 -1 -1104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 2704 0 0 -1 -1104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 -2704 0 0 -1 -1104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707107 -0.176777" album="" material="bm_wood" texgens="1 0 0 -2704 0 -1 0 9712 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.707107 -0.707107 -0.176777" album="" material="bm_wood" texgens="-1 0 0 2704 0 -1 0 9712 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="198" owner="0" type="0" pos="-10 -39.0625 4.3125" rot="1 0 0 0" scale="" transform="1 0 0 -10 0 1 0 -39.0625 0 0 1 4.3125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 0.0625 0.187499" />
                            <Vertex pos="1.5 0.0625 -0.312499" />
                            <Vertex pos="1.5 -0.0625 0.312499" />
                            <Vertex pos="1.5 -0.0625 -0.187499" />
                            <Vertex pos="-1.5 0.0625 0.187499" />
                            <Vertex pos="-1.5 0.0625 -0.312499" />
                            <Vertex pos="-1.375 -0.0625 0.312499" />
                            <Vertex pos="-1.375 -0.0625 -0.187499" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -1.5" album="" material="bm_wood" texgens="0 1 0 -10000 0 0 -1 -1104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -1.01647" album="" material="bm_wood" texgens="0 -1 0 10000 0 0 -1 -1104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 2560 0 0 -1 -1104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 -2560 0 0 -1 -1104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707107 -0.176776" album="" material="bm_wood" texgens="1 0 0 -2560 0 -1 0 10000 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.707107 -0.707107 -0.176776" album="" material="bm_wood" texgens="-1 0 0 2560 0 -1 0 10000 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="199" owner="0" type="0" pos="-12.5625 -40.4375 4.3125" rot="1 0 0 0" scale="" transform="1 0 0 -12.5625 0 1 0 -40.4375 0 0 1 4.3125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.062499 2.4375 0.187502" />
                            <Vertex pos="0.062499 2.4375 -0.3125" />
                            <Vertex pos="0.062499 -2.5625 0.187502" />
                            <Vertex pos="0.062499 -2.5625 -0.3125" />
                            <Vertex pos="-0.062499 2.5625 0.3125" />
                            <Vertex pos="-0.062499 2.5625 -0.187502" />
                            <Vertex pos="-0.062499 -2.5625 0.3125" />
                            <Vertex pos="-0.062499 -2.5625 -0.187502" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.062499" album="" material="bm_wood" texgens="0 1 0 -10352 0 0 -1 -1104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.062499" album="" material="bm_wood" texgens="0 -1 0 10352 0 0 -1 -1104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707112 0.707101 -0 -1.76775" album="" material="bm_wood" texgens="-1 0 0 3216 0 0 -1 -1104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2.5625" album="" material="bm_wood" texgens="1 0 0 -3216 0 0 -1 -1104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -0.176777" album="" material="bm_wood" texgens="1 0 0 -3216 0 -1 0 10352 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 0 -0.707107 -0.176777" album="" material="bm_wood" texgens="-1 0 0 3216 0 -1 0 10352 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="200" owner="0" type="0" pos="-11.4375 -41 4.3125" rot="1 0 0 0" scale="" transform="1 0 0 -11.4375 0 1 0 -41 0 0 1 4.3125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.0625 1.875 0.3125" />
                            <Vertex pos="0.0625 1.875 -0.1875" />
                            <Vertex pos="0.0625 -2 0.312501" />
                            <Vertex pos="0.0625 -2 -0.187501" />
                            <Vertex pos="-0.0625 2 0.1875" />
                            <Vertex pos="-0.0625 2 -0.3125" />
                            <Vertex pos="-0.0625 -2 0.187501" />
                            <Vertex pos="-0.0625 -2 -0.312501" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.0625" album="" material="bm_wood" texgens="0 1 0 -10496 0 0 -1 -1104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.0625" album="" material="bm_wood" texgens="0 -1 0 10496 0 0 -1 -1104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -1.37002" album="" material="bm_wood" texgens="-1 0 0 2928 0 0 -1 -1104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_wood" texgens="1 0 0 -2928 0 0 -1 -1104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 1.7649e-007 0.707107 -0.176777" album="" material="bm_wood" texgens="1 0 0 -2928 0 -1 0 10496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 1.82183e-007 -0.707107 -0.176777" album="" material="bm_wood" texgens="-1 0 0 2928 0 -1 0 10496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="201" owner="0" type="0" pos="5 -77.4375 4.3125" rot="1 0 0 0" scale="" transform="1 0 0 5 0 1 0 -77.4375 0 0 1 4.3125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.0625 0.312504" />
                            <Vertex pos="2 0.0625 -0.187507" />
                            <Vertex pos="2 -0.0625 0.187507" />
                            <Vertex pos="2 -0.0625 -0.312504" />
                            <Vertex pos="-2 0.0625 0.312504" />
                            <Vertex pos="-2 0.0625 -0.187507" />
                            <Vertex pos="-2 -0.0625 0.187507" />
                            <Vertex pos="-2 -0.0625 -0.312504" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_wood" texgens="0 1 0 -19824 0 0 -1 -1104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -2" album="" material="bm_wood" texgens="0 -1 0 19824 0 0 -1 -1104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 -1280 0 0 -1 -1104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 1280 0 0 -1 -1104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707098 0.707115 -0.176783" album="" material="bm_wood" texgens="1 0 0 1280 0 -1 0 19824 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.707098 -0.707115 -0.176783" album="" material="bm_wood" texgens="-1 0 0 -1280 0 -1 0 19824 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="202" owner="0" type="0" pos="5 -78.5625 4.3125" rot="1 0 0 0" scale="" transform="1 0 0 5 0 1 0 -78.5625 0 0 1 4.3125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.0625 0.187499" />
                            <Vertex pos="2 0.0625 -0.312501" />
                            <Vertex pos="2 -0.0625 0.312502" />
                            <Vertex pos="2 -0.0625 -0.187499" />
                            <Vertex pos="-2 0.0625 0.187499" />
                            <Vertex pos="-2 0.0625 -0.312501" />
                            <Vertex pos="-2 -0.0625 0.312502" />
                            <Vertex pos="-2 -0.0625 -0.187499" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -2" album="" material="bm_wood" texgens="0 1 0 -20112 0 0 -1 -1104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_wood" texgens="0 -1 0 20112 0 0 -1 -1104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 -1280 0 0 -1 -1104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 1280 0 0 -1 -1104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707115 0.707098 -0.176775" album="" material="bm_wood" texgens="1 0 0 1280 0 -1 0 20112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.707112 -0.707101 -0.176775" album="" material="bm_wood" texgens="-1 0 0 -1280 0 -1 0 20112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="203" owner="0" type="0" pos="7.5 -77.4375 4.43751" rot="1 0 0 0" scale="" transform="1 0 0 7.5 0 1 0 -77.4375 0 0 1 4.43751 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.0625 0.437498" />
                            <Vertex pos="0.5 0.0625 -0.0625024" />
                            <Vertex pos="0.5 -0.0625 0.312502" />
                            <Vertex pos="0.5 -0.0625 -0.187499" />
                            <Vertex pos="-0.5 0.0625 0.187498" />
                            <Vertex pos="-0.5 0.0625 -0.312502" />
                            <Vertex pos="-0.5 -0.0625 0.0625024" />
                            <Vertex pos="-0.5 -0.0625 -0.437499" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_wood" texgens="0 1 0 -19824 0 0 -1 -1136 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.5" album="" material="bm_wood" texgens="0 -1 0 19824 0 0 -1 -1136 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 -1920 0 0 -1 -1136 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 1920 0 0 -1 -1136 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.174081 -0.696298 0.696323 -0.174081" album="" material="bm_wood" texgens="1 0 0 1920 0 -1 0 19824 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.17408 0.696301 -0.69632 -0.17408" album="" material="bm_wood" texgens="-1 0 0 -1920 0 -1 0 19824 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="204" owner="0" type="0" pos="7.5 -78.5625 4.4375" rot="1 0 0 0" scale="" transform="1 0 0 7.5 0 1 0 -78.5625 0 0 1 4.4375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.0625 0.312494" />
                            <Vertex pos="0.5 0.0625 -0.187496" />
                            <Vertex pos="0.5 -0.0625 0.437496" />
                            <Vertex pos="0.5 -0.0625 -0.0624938" />
                            <Vertex pos="-0.5 0.0625 0.0624943" />
                            <Vertex pos="-0.5 0.0625 -0.437496" />
                            <Vertex pos="-0.5 -0.0625 0.187496" />
                            <Vertex pos="-0.5 -0.0625 -0.312494" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.5" album="" material="bm_wood" texgens="0 1 0 -20112 0 0 -1 -1136 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_wood" texgens="0 -1 0 20112 0 0 -1 -1136 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 -1920 0 0 -1 -1136 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 1920 0 0 -1 -1136 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.174076 0.696316 0.696306 -0.174073" album="" material="bm_wood" texgens="1 0 0 1920 0 -1 0 20112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.174076 -0.696317 -0.696305 -0.174073" album="" material="bm_wood" texgens="-1 0 0 -1920 0 -1 0 20112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="205" owner="0" type="0" pos="8.5 -77.4375 4.8125" rot="1 0 0 0" scale="" transform="1 0 0 8.5 0 1 0 -77.4375 0 0 1 4.8125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.0625 0.562498" />
                            <Vertex pos="0.5 0.0625 0.0625" />
                            <Vertex pos="0.5 -0.0625 0.4375" />
                            <Vertex pos="0.5 -0.0625 -0.0624981" />
                            <Vertex pos="-0.5 0.0625 0.0624981" />
                            <Vertex pos="-0.5 0.0625 -0.4375" />
                            <Vertex pos="-0.5 -0.0625 -0.0625" />
                            <Vertex pos="-0.5 -0.0625 -0.562498" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_wood" texgens="0 1 0 -19824 0 0 -1 -1232 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.5" album="" material="bm_wood" texgens="0 -1 0 19824 0 0 -1 -1232 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 -2176 0 0 -1 -1232 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 2176 0 0 -1 -1232 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.333335 -0.666661 0.666671 -0.166667" album="" material="bm_wood" texgens="1 0 0 2176 0 -1 0 19824 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.333335 0.666661 -0.666671 -0.166667" album="" material="bm_wood" texgens="-1 0 0 -2176 0 -1 0 19824 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="206" owner="0" type="0" pos="8.5 -78.5625 4.8125" rot="1 0 0 0" scale="" transform="1 0 0 8.5 0 1 0 -78.5625 0 0 1 4.8125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.0625 0.4375" />
                            <Vertex pos="0.5 0.0625 -0.0624981" />
                            <Vertex pos="0.5 -0.0625 0.562498" />
                            <Vertex pos="0.5 -0.0625 0.0625" />
                            <Vertex pos="-0.5 0.0625 -0.0625" />
                            <Vertex pos="-0.5 0.0625 -0.562498" />
                            <Vertex pos="-0.5 -0.0625 0.0624981" />
                            <Vertex pos="-0.5 -0.0625 -0.4375" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.5" album="" material="bm_wood" texgens="0 1 0 -20112 0 0 -1 -1232 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_wood" texgens="0 -1 0 20112 0 0 -1 -1232 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 -2176 0 0 -1 -1232 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 2176 0 0 -1 -1232 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.333336 0.666661 0.666671 -0.166667" album="" material="bm_wood" texgens="1 0 0 2176 0 -1 0 20112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.333336 -0.666661 -0.666671 -0.166667" album="" material="bm_wood" texgens="-1 0 0 -2176 0 -1 0 20112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="207" owner="0" type="0" pos="13 -77.4375 5.8125" rot="1 0 0 0" scale="" transform="1 0 0 13 0 1 0 -77.4375 0 0 1 5.8125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.0625 0.312499" />
                            <Vertex pos="2 0.0625 -0.187501" />
                            <Vertex pos="2 -0.0625 0.187501" />
                            <Vertex pos="2 -0.0625 -0.312499" />
                            <Vertex pos="-2 0.0625 0.312499" />
                            <Vertex pos="-2 0.0625 -0.187501" />
                            <Vertex pos="-2 -0.0625 0.187501" />
                            <Vertex pos="-2 -0.0625 -0.312499" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_wood" texgens="0 1 0 -19824 0 0 -1 -1488 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -2" album="" material="bm_wood" texgens="0 -1 0 19824 0 0 -1 -1488 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 -3328 0 0 -1 -1488 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 3328 0 0 -1 -1488 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707101 0.707112 -0.176778" album="" material="bm_wood" texgens="1 0 0 3328 0 -1 0 19824 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.707101 -0.707112 -0.176778" album="" material="bm_wood" texgens="-1 0 0 -3328 0 -1 0 19824 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="208" owner="0" type="0" pos="13 -78.5625 5.81252" rot="1 0 0 0" scale="" transform="1 0 0 13 0 1 0 -78.5625 0 0 1 5.81252 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.0624924 0.187488" />
                            <Vertex pos="2 0.0624924 -0.312474" />
                            <Vertex pos="1.87501 -0.0624924 0.312475" />
                            <Vertex pos="1.87501 -0.0624924 -0.187488" />
                            <Vertex pos="-2 0.0624924 0.187488" />
                            <Vertex pos="-2 0.0624924 -0.312474" />
                            <Vertex pos="-2 -0.0624924 0.312475" />
                            <Vertex pos="-2 -0.0624924 -0.187488" />
                        </Vertices>
                        <Face id="0" plane="0.707092 -0.707121 0 -1.36999" album="" material="bm_wood" texgens="0 1 0 -20112 0 0 -1 -1488 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_wood" texgens="0 -1 0 20112 0 0 -1 -1488 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0624924" album="" material="bm_wood" texgens="-1 0 0 -3328 0 0 -1 -1488 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0624924" album="" material="bm_wood" texgens="1 0 0 3328 0 0 -1 -1488 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707113 0.707101 -0.176762" album="" material="bm_wood" texgens="1 0 0 3328 0 -1 0 20112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.70711 -0.707103 -0.176762" album="" material="bm_wood" texgens="-1 0 0 -3328 0 -1 0 20112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="209" owner="0" type="0" pos="14.9375 -80.0625 5.8125" rot="1 0 0 0" scale="" transform="1 0 0 14.9375 0 1 0 -80.0625 0 0 1 5.8125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.0625 1.56249 0.1875" />
                            <Vertex pos="0.0625 1.56249 -0.3125" />
                            <Vertex pos="0.0625 -1.43749 0.1875" />
                            <Vertex pos="0.0625 -1.43749 -0.3125" />
                            <Vertex pos="-0.0625 1.43749 0.3125" />
                            <Vertex pos="-0.0625 1.43749 -0.1875" />
                            <Vertex pos="-0.0625 -1.56249 0.3125" />
                            <Vertex pos="-0.0625 -1.56249 -0.1875" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.0625" album="" material="bm_wood" texgens="0 1 0 -20496 0 0 -1 -1488 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.0625" album="" material="bm_wood" texgens="0 -1 0 20496 0 0 -1 -1488 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -1.06065" album="" material="bm_wood" texgens="-1 0 0 -3824 0 0 -1 -1488 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -1.06065" album="" material="bm_wood" texgens="1 0 0 3824 0 0 -1 -1488 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -0.176777" album="" material="bm_wood" texgens="1 0 0 3824 0 -1 0 20496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 0 -0.707107 -0.176777" album="" material="bm_wood" texgens="-1 0 0 -3824 0 -1 0 20496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="210" owner="0" type="0" pos="16.0625 -79 5.8125" rot="1 0 0 0" scale="" transform="1 0 0 16.0625 0 1 0 -79 0 0 1 5.8125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.0625 1.49999 0.3125" />
                            <Vertex pos="0.0625 1.49999 -0.1875" />
                            <Vertex pos="0.0625 -1.37499 0.3125" />
                            <Vertex pos="0.0625 -1.37499 -0.1875" />
                            <Vertex pos="-0.0625 1.49999 0.1875" />
                            <Vertex pos="-0.0625 1.49999 -0.3125" />
                            <Vertex pos="-0.0625 -1.49999 0.1875" />
                            <Vertex pos="-0.0625 -1.49999 -0.3125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.0625" album="" material="bm_wood" texgens="0 1 0 -20224 0 0 -1 -1488 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.0625" album="" material="bm_wood" texgens="0 -1 0 20224 0 0 -1 -1488 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1.49999" album="" material="bm_wood" texgens="-1 0 0 -4112 0 0 -1 -1488 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -1.01646" album="" material="bm_wood" texgens="1 0 0 4112 0 0 -1 -1488 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -0.176777" album="" material="bm_wood" texgens="1 0 0 4112 0 -1 0 20224 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -0.176777" album="" material="bm_wood" texgens="-1 0 0 -4112 0 -1 0 20224 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="211" owner="0" type="0" pos="17 -80.4375 5.8125" rot="1 0 0 0" scale="" transform="1 0 0 17 0 1 0 -80.4375 0 0 1 5.8125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.00001 0.0625 0.312497" />
                            <Vertex pos="1.00001 0.0625 -0.187493" />
                            <Vertex pos="1.00001 -0.0625 0.187494" />
                            <Vertex pos="1.00001 -0.0625 -0.312496" />
                            <Vertex pos="-0.875002 0.0625 0.312497" />
                            <Vertex pos="-0.875002 0.0625 -0.187493" />
                            <Vertex pos="-1 -0.0625 0.187494" />
                            <Vertex pos="-1 -0.0625 -0.312496" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.00001" album="" material="bm_wood" texgens="0 1 0 -20592 0 0 -1 -1488 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707112 0.707101 0 -0.662919" album="" material="bm_wood" texgens="0 -1 0 20592 0 0 -1 -1488 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 -4352 0 0 -1 -1488 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 4352 0 0 -1 -1488 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707115 0.707098 -0.176771" album="" material="bm_wood" texgens="1 0 0 4352 0 -1 0 20592 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.707115 -0.707098 -0.176771" album="" material="bm_wood" texgens="-1 0 0 -4352 0 -1 0 20592 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="212" owner="0" type="0" pos="16.4375 -81.5625 5.81248" rot="1 0 0 0" scale="" transform="1 0 0 16.4375 0 1 0 -81.5625 0 0 1 5.81248 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5625 0.0625 0.187516" />
                            <Vertex pos="1.5625 0.0625 -0.312514" />
                            <Vertex pos="1.5625 -0.0625 0.312514" />
                            <Vertex pos="1.5625 -0.0625 -0.187517" />
                            <Vertex pos="-1.43751 0.0625 0.187516" />
                            <Vertex pos="-1.43751 0.0625 -0.312484" />
                            <Vertex pos="-1.56251 -0.0625 0.312514" />
                            <Vertex pos="-1.56251 -0.0625 -0.187486" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -1.5625" album="" material="bm_wood" texgens="0 1 0 -20880 0 0 -1 -1487.99 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -1.06067" album="" material="bm_wood" texgens="0 -1 0 20880 0 0 -1 -1487.99 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 -4208 0 0 -1 -1487.99 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 4208 0 0 -1 -1487.99 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707101 0.707112 -0.176789" album="" material="bm_wood" texgens="1 0 0 4208 0 -1 0 20880 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-7.01667e-006 -0.707098 -0.707115 -0.176779" album="" material="bm_wood" texgens="-1 0 0 -4208 0 -1 0 20880 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="213" owner="0" type="0" pos="18.5 -80.4375 5.93751" rot="1 0 0 0" scale="" transform="1 0 0 18.5 0 1 0 -80.4375 0 0 1 5.93751 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.0625 0.437504" />
                            <Vertex pos="0.5 0.0625 -0.0625076" />
                            <Vertex pos="0.5 -0.0625 0.312508" />
                            <Vertex pos="0.5 -0.0625 -0.187504" />
                            <Vertex pos="-0.5 0.0625 0.187504" />
                            <Vertex pos="-0.5 0.0625 -0.312508" />
                            <Vertex pos="-0.5 -0.0625 0.0625081" />
                            <Vertex pos="-0.5 -0.0625 -0.437504" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_wood" texgens="0 1 0 -20592 0 0 -1 -1520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.5" album="" material="bm_wood" texgens="0 -1 0 20592 0 0 -1 -1520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 -4736 0 0 -1 -1520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 4736 0 0 -1 -1520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.17408 -0.696299 0.696322 -0.174085" album="" material="bm_wood" texgens="1 0 0 4736 0 -1 0 20592 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.17408 0.6963 -0.69632 -0.174084" album="" material="bm_wood" texgens="-1 0 0 -4736 0 -1 0 20592 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="214" owner="0" type="0" pos="18.5 -81.5625 5.93749" rot="1 0 0 0" scale="" transform="1 0 0 18.5 0 1 0 -81.5625 0 0 1 5.93749 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.0625 0.312505" />
                            <Vertex pos="0.5 0.0625 -0.187507" />
                            <Vertex pos="0.5 -0.0625 0.437507" />
                            <Vertex pos="0.5 -0.0625 -0.0625052" />
                            <Vertex pos="-0.5 0.0625 0.0625048" />
                            <Vertex pos="-0.5 0.0625 -0.437507" />
                            <Vertex pos="-0.5 -0.0625 0.187507" />
                            <Vertex pos="-0.5 -0.0625 -0.312505" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.5" album="" material="bm_wood" texgens="0 1 0 -20880 0 0 -1 -1520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_wood" texgens="0 -1 0 20880 0 0 -1 -1520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 -4736 0 0 -1 -1520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 4736 0 0 -1 -1520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.174076 0.696317 0.696305 -0.17408" album="" material="bm_wood" texgens="1 0 0 4736 0 -1 0 20880 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.174076 -0.696316 -0.696306 -0.174081" album="" material="bm_wood" texgens="-1 0 0 -4736 0 -1 0 20880 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="215" owner="0" type="0" pos="19.5 -80.4375 6.3125" rot="1 0 0 0" scale="" transform="1 0 0 19.5 0 1 0 -80.4375 0 0 1 6.3125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.0625 0.562498" />
                            <Vertex pos="0.5 0.0625 0.0625" />
                            <Vertex pos="0.5 -0.0625 0.4375" />
                            <Vertex pos="0.5 -0.0625 -0.0624981" />
                            <Vertex pos="-0.5 0.0625 0.0624981" />
                            <Vertex pos="-0.5 0.0625 -0.4375" />
                            <Vertex pos="-0.5 -0.0625 -0.0625" />
                            <Vertex pos="-0.5 -0.0625 -0.562498" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_wood" texgens="0 1 0 -20592 0 0 -1 -1616 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.5" album="" material="bm_wood" texgens="0 -1 0 20592 0 0 -1 -1616 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 -4992 0 0 -1 -1616 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 4992 0 0 -1 -1616 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.333335 -0.666661 0.666671 -0.166667" album="" material="bm_wood" texgens="1 0 0 4992 0 -1 0 20592 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.333335 0.666661 -0.666671 -0.166667" album="" material="bm_wood" texgens="-1 0 0 -4992 0 -1 0 20592 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="216" owner="0" type="0" pos="19.5 -81.5625 6.3125" rot="1 0 0 0" scale="" transform="1 0 0 19.5 0 1 0 -81.5625 0 0 1 6.3125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.0625 0.437503" />
                            <Vertex pos="0.5 0.0625 -0.062501" />
                            <Vertex pos="0.5 -0.0625 0.562501" />
                            <Vertex pos="0.5 -0.0625 0.0624971" />
                            <Vertex pos="-0.5 0.0625 -0.0624971" />
                            <Vertex pos="-0.5 0.0625 -0.562501" />
                            <Vertex pos="-0.5 -0.0625 0.062501" />
                            <Vertex pos="-0.5 -0.0625 -0.437503" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.5" album="" material="bm_wood" texgens="0 1 0 -20880 0 0 -1 -1616 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_wood" texgens="0 -1 0 20880 0 0 -1 -1616 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 -4992 0 0 -1 -1616 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 4992 0 0 -1 -1616 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.333336 0.666661 0.666671 -0.166669" album="" material="bm_wood" texgens="1 0 0 4992 0 -1 0 20880 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.333336 -0.666661 -0.666671 -0.166669" album="" material="bm_wood" texgens="-1 0 0 -4992 0 -1 0 20880 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="217" owner="0" type="0" pos="20.5 -80.4375 6.6875" rot="1 0 0 0" scale="" transform="1 0 0 20.5 0 1 0 -80.4375 0 0 1 6.6875 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.0625 0.437499" />
                            <Vertex pos="0.5 0.0625 -0.0625024" />
                            <Vertex pos="0.5 -0.0625 0.312502" />
                            <Vertex pos="0.5 -0.0625 -0.187499" />
                            <Vertex pos="-0.5 0.0625 0.187499" />
                            <Vertex pos="-0.5 0.0625 -0.312502" />
                            <Vertex pos="-0.5 -0.0625 0.0625024" />
                            <Vertex pos="-0.5 -0.0625 -0.437499" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_wood" texgens="0 1 0 -20592 0 0 -1 -1712 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.5" album="" material="bm_wood" texgens="0 -1 0 20592 0 0 -1 -1712 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 -5248 0 0 -1 -1712 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 5248 0 0 -1 -1712 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.17408 -0.696301 0.69632 -0.17408" album="" material="bm_wood" texgens="1 0 0 5248 0 -1 0 20592 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.17408 0.696301 -0.69632 -0.17408" album="" material="bm_wood" texgens="-1 0 0 -5248 0 -1 0 20592 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="218" owner="0" type="0" pos="20.5 -81.5625 6.6875" rot="1 0 0 0" scale="" transform="1 0 0 20.5 0 1 0 -81.5625 0 0 1 6.6875 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.0625 0.3125" />
                            <Vertex pos="0.5 0.0625 -0.187501" />
                            <Vertex pos="0.5 -0.0625 0.437501" />
                            <Vertex pos="0.5 -0.0625 -0.0624995" />
                            <Vertex pos="-0.5 0.0625 0.0625" />
                            <Vertex pos="-0.5 0.0625 -0.437501" />
                            <Vertex pos="-0.5 -0.0625 0.187501" />
                            <Vertex pos="-0.5 -0.0625 -0.3125" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.5" album="" material="bm_wood" texgens="0 1 0 -20880 0 0 -1 -1712 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_wood" texgens="0 -1 0 20880 0 0 -1 -1712 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 -5248 0 0 -1 -1712 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 5248 0 0 -1 -1712 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.174077 0.696313 0.696308 -0.174077" album="" material="bm_wood" texgens="1 0 0 5248 0 -1 0 20880 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.174077 -0.696315 -0.696307 -0.174077" album="" material="bm_wood" texgens="-1 0 0 -5248 0 -1 0 20880 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="219" owner="0" type="0" pos="22 -80.4375 6.8125" rot="1 0 0 0" scale="" transform="1 0 0 22 0 1 0 -80.4375 0 0 1 6.8125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.0625 0.312497" />
                            <Vertex pos="1 0.0625 -0.187493" />
                            <Vertex pos="1 -0.0625 0.187494" />
                            <Vertex pos="1 -0.0625 -0.312496" />
                            <Vertex pos="-1 0.0625 0.312497" />
                            <Vertex pos="-1 0.0625 -0.187493" />
                            <Vertex pos="-1 -0.0625 0.187494" />
                            <Vertex pos="-1 -0.0625 -0.312496" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_wood" texgens="0 1 0 -20592 0 0 -1 -1744 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -1" album="" material="bm_wood" texgens="0 -1 0 20592 0 0 -1 -1744 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 -5632 0 0 -1 -1744 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 5632 0 0 -1 -1744 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707115 0.707098 -0.176771" album="" material="bm_wood" texgens="1 0 0 5632 0 -1 0 20592 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.707115 -0.707098 -0.176771" album="" material="bm_wood" texgens="-1 0 0 -5632 0 -1 0 20592 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="220" owner="0" type="0" pos="22 -81.5625 6.8125" rot="1 0 0 0" scale="" transform="1 0 0 22 0 1 0 -81.5625 0 0 1 6.8125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.0625 0.187504" />
                            <Vertex pos="1 0.0625 -0.312502" />
                            <Vertex pos="1 -0.0625 0.312501" />
                            <Vertex pos="1 -0.0625 -0.187504" />
                            <Vertex pos="-1 0.0625 0.187504" />
                            <Vertex pos="-1 0.0625 -0.312502" />
                            <Vertex pos="-1 -0.0625 0.312501" />
                            <Vertex pos="-1 -0.0625 -0.187504" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -1" album="" material="bm_wood" texgens="0 1 0 -20880 0 0 -1 -1744 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_wood" texgens="0 -1 0 20880 0 0 -1 -1744 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 -5632 0 0 -1 -1744 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 5632 0 0 -1 -1744 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707098 0.707115 -0.176781" album="" material="bm_wood" texgens="1 0 0 5632 0 -1 0 20880 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.707101 -0.707112 -0.17678" album="" material="bm_wood" texgens="-1 0 0 -5632 0 -1 0 20880 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="221" owner="0" type="0" pos="14.9375 -73.4375 5.8125" rot="1 0 0 0" scale="" transform="1 0 0 14.9375 0 1 0 -73.4375 0 0 1 5.8125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.0625 0.9375 0.1875" />
                            <Vertex pos="0.0625 0.9375 -0.312499" />
                            <Vertex pos="0.0625 -1.0625 0.1875" />
                            <Vertex pos="0.0625 -1.0625 -0.3125" />
                            <Vertex pos="-0.0625 1.0625 0.3125" />
                            <Vertex pos="-0.0625 1.0625 -0.187499" />
                            <Vertex pos="-0.0625 -1.0625 0.3125" />
                            <Vertex pos="-0.0625 -1.0625 -0.1875" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.0625" album="" material="bm_wood" texgens="0 1 0 -18800 0 0 -1 -1488 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.0625" album="" material="bm_wood" texgens="0 -1 0 18800 0 0 -1 -1488 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -0.707107" album="" material="bm_wood" texgens="-1 0 0 -3824 0 0 -1 -1488 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.0625" album="" material="bm_wood" texgens="1 0 0 3824 0 0 -1 -1488 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -0.176777" album="" material="bm_wood" texgens="1 0 0 3824 0 -1 0 18800 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 3.58248e-007 -0.707107 -0.176776" album="" material="bm_wood" texgens="-1 0 0 -3824 0 -1 0 18800 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="222" owner="0" type="0" pos="16.0625 -74 5.8125" rot="1 0 0 0" scale="" transform="1 0 0 16.0625 0 1 0 -74 0 0 1 5.8125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.0625 0.375 0.3125" />
                            <Vertex pos="0.0625 0.375 -0.1875" />
                            <Vertex pos="0.0625 -0.5 0.3125" />
                            <Vertex pos="0.0625 -0.5 -0.1875" />
                            <Vertex pos="-0.0625 0.5 0.1875" />
                            <Vertex pos="-0.0625 0.5 -0.3125" />
                            <Vertex pos="-0.0625 -0.5 0.1875" />
                            <Vertex pos="-0.0625 -0.5 -0.3125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.0625" album="" material="bm_wood" texgens="0 1 0 -18944 0 0 -1 -1488 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.0625" album="" material="bm_wood" texgens="0 -1 0 18944 0 0 -1 -1488 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -0.309359" album="" material="bm_wood" texgens="-1 0 0 -4112 0 0 -1 -1488 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_wood" texgens="1 0 0 4112 0 0 -1 -1488 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -0.176777" album="" material="bm_wood" texgens="1 0 0 4112 0 -1 0 18944 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -0.176777" album="" material="bm_wood" texgens="-1 0 0 -4112 0 -1 0 18944 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="223" owner="0" type="0" pos="16.9375 -72.4375 5.8125" rot="1 0 0 0" scale="" transform="1 0 0 16.9375 0 1 0 -72.4375 0 0 1 5.8125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.0625 0.0625 0.312499" />
                            <Vertex pos="2.0625 0.0625 -0.187501" />
                            <Vertex pos="2.0625 -0.0625 0.187501" />
                            <Vertex pos="2.0625 -0.0625 -0.312499" />
                            <Vertex pos="-2.0625 0.0625 0.312499" />
                            <Vertex pos="-2.0625 0.0625 -0.187501" />
                            <Vertex pos="-1.9375 -0.0625 0.187501" />
                            <Vertex pos="-1.9375 -0.0625 -0.312499" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2.0625" album="" material="bm_wood" texgens="0 1 0 -18544 0 0 -1 -1488 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -1.41421" album="" material="bm_wood" texgens="0 -1 0 18544 0 0 -1 -1488 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 -4336 0 0 -1 -1488 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 4336 0 0 -1 -1488 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707101 0.707112 -0.176778" album="" material="bm_wood" texgens="1 0 0 4336 0 -1 0 18544 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.707101 -0.707112 -0.176778" album="" material="bm_wood" texgens="-1 0 0 -4336 0 -1 0 18544 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="224" owner="0" type="0" pos="17.5 -73.5625 5.81248" rot="1 0 0 0" scale="" transform="1 0 0 17.5 0 1 0 -73.5625 0 0 1 5.81248 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 0.0625 0.187506" />
                            <Vertex pos="1.5 0.0625 -0.312509" />
                            <Vertex pos="1.5 -0.0625 0.312509" />
                            <Vertex pos="1.5 -0.0625 -0.187479" />
                            <Vertex pos="-1.5 0.0625 0.187506" />
                            <Vertex pos="-1.5 0.0625 -0.312509" />
                            <Vertex pos="-1.375 -0.0625 0.312509" />
                            <Vertex pos="-1.375 -0.0625 -0.187479" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -1.5" album="" material="bm_wood" texgens="0 1 0 -18832 0 0 -1 -1488 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -1.01647" album="" material="bm_wood" texgens="0 -1 0 18832 0 0 -1 -1488 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 -4480 0 0 -1 -1488 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 4480 0 0 -1 -1488 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707115 0.707098 -0.17678" album="" material="bm_wood" texgens="1 0 0 4480 0 -1 0 18832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.707192 -0.707022 -0.176751" album="" material="bm_wood" texgens="-1 0 0 -4480 0 -1 0 18832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="225" owner="0" type="0" pos="19.5 -72.4375 5.9375" rot="1 0 0 0" scale="" transform="1 0 0 19.5 0 1 0 -72.4375 0 0 1 5.9375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.0625 0.437501" />
                            <Vertex pos="0.5 0.0625 -0.0624995" />
                            <Vertex pos="0.5 -0.0625 0.3125" />
                            <Vertex pos="0.5 -0.0625 -0.187501" />
                            <Vertex pos="-0.5 0.0625 0.187501" />
                            <Vertex pos="-0.5 0.0625 -0.3125" />
                            <Vertex pos="-0.5 -0.0625 0.0624995" />
                            <Vertex pos="-0.5 -0.0625 -0.437501" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_wood" texgens="0 1 0 -18544 0 0 -1 -1520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.5" album="" material="bm_wood" texgens="0 -1 0 18544 0 0 -1 -1520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 -4992 0 0 -1 -1520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 4992 0 0 -1 -1520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.174077 -0.696315 0.696307 -0.174077" album="" material="bm_wood" texgens="1 0 0 4992 0 -1 0 18544 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.174077 0.696315 -0.696307 -0.174077" album="" material="bm_wood" texgens="-1 0 0 -4992 0 -1 0 18544 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="226" owner="0" type="0" pos="19.5 -73.5625 5.9375" rot="1 0 0 0" scale="" transform="1 0 0 19.5 0 1 0 -73.5625 0 0 1 5.9375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.0625 0.312502" />
                            <Vertex pos="0.5 0.0625 -0.187499" />
                            <Vertex pos="0.5 -0.0625 0.437499" />
                            <Vertex pos="0.5 -0.0625 -0.0625024" />
                            <Vertex pos="-0.5 0.0625 0.0625024" />
                            <Vertex pos="-0.5 0.0625 -0.437499" />
                            <Vertex pos="-0.5 -0.0625 0.187499" />
                            <Vertex pos="-0.5 -0.0625 -0.312502" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.5" album="" material="bm_wood" texgens="0 1 0 -18832 0 0 -1 -1520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_wood" texgens="0 -1 0 18832 0 0 -1 -1520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 -4992 0 0 -1 -1520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 4992 0 0 -1 -1520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.17408 0.696301 0.69632 -0.17408" album="" material="bm_wood" texgens="1 0 0 4992 0 -1 0 18832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.17408 -0.696301 -0.69632 -0.17408" album="" material="bm_wood" texgens="-1 0 0 -4992 0 -1 0 18832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="227" owner="0" type="0" pos="20.5 -72.4375 6.31251" rot="1 0 0 0" scale="" transform="1 0 0 20.5 0 1 0 -72.4375 0 0 1 6.31251 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.0625 0.562498" />
                            <Vertex pos="0.5 0.0625 0.0625057" />
                            <Vertex pos="0.5 -0.0625 0.437494" />
                            <Vertex pos="0.5 -0.0625 -0.0624981" />
                            <Vertex pos="-0.5 0.0625 0.0624981" />
                            <Vertex pos="-0.5 0.0625 -0.437494" />
                            <Vertex pos="-0.5 -0.0625 -0.0625057" />
                            <Vertex pos="-0.5 -0.0625 -0.562498" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_wood" texgens="0 1 0 -18544 0 0 -1 -1616 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.5" album="" material="bm_wood" texgens="0 -1 0 18544 0 0 -1 -1616 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 -5248 0 0 -1 -1616 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 5248 0 0 -1 -1616 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.333329 -0.666678 0.666658 -0.166662" album="" material="bm_wood" texgens="1 0 0 5248 0 -1 0 18544 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.333329 0.666678 -0.666658 -0.166662" album="" material="bm_wood" texgens="-1 0 0 -5248 0 -1 0 18544 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="228" owner="0" type="0" pos="20.5 -73.5625 6.3125" rot="1 0 0 0" scale="" transform="1 0 0 20.5 0 1 0 -73.5625 0 0 1 6.3125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.0625 0.437497" />
                            <Vertex pos="0.5 0.0625 -0.062501" />
                            <Vertex pos="0.5 -0.0625 0.562501" />
                            <Vertex pos="0.5 -0.0625 0.0625029" />
                            <Vertex pos="-0.5 0.0625 -0.0625029" />
                            <Vertex pos="-0.5 0.0625 -0.562501" />
                            <Vertex pos="-0.5 -0.0625 0.062501" />
                            <Vertex pos="-0.5 -0.0625 -0.437497" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.5" album="" material="bm_wood" texgens="0 1 0 -18832 0 0 -1 -1616 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_wood" texgens="0 -1 0 18832 0 0 -1 -1616 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 -5248 0 0 -1 -1616 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 5248 0 0 -1 -1616 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.333329 0.666678 0.666657 -0.166664" album="" material="bm_wood" texgens="1 0 0 5248 0 -1 0 18832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.333329 -0.666678 -0.666657 -0.166664" album="" material="bm_wood" texgens="-1 0 0 -5248 0 -1 0 18832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="229" owner="0" type="0" pos="28 -72.4375 6.8125" rot="1 0 0 0" scale="" transform="1 0 0 28 0 1 0 -72.4375 0 0 1 6.8125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.0625 0.312499" />
                            <Vertex pos="1 0.0625 -0.187501" />
                            <Vertex pos="1 -0.0625 0.187502" />
                            <Vertex pos="1 -0.0625 -0.312499" />
                            <Vertex pos="-1 0.0625 0.312499" />
                            <Vertex pos="-1 0.0625 -0.187501" />
                            <Vertex pos="-1 -0.0625 0.187502" />
                            <Vertex pos="-1 -0.0625 -0.312499" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_wood" texgens="0 1 0 -18544 0 0 -1 -1744 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -1" album="" material="bm_wood" texgens="0 -1 0 18544 0 0 -1 -1744 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 -7168 0 0 -1 -1744 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 7168 0 0 -1 -1744 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707098 0.707115 -0.176779" album="" material="bm_wood" texgens="1 0 0 7168 0 -1 0 18544 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.707101 -0.707112 -0.176778" album="" material="bm_wood" texgens="-1 0 0 -7168 0 -1 0 18544 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="230" owner="0" type="0" pos="28 -73.5625 6.81251" rot="1 0 0 0" scale="" transform="1 0 0 28 0 1 0 -73.5625 0 0 1 6.81251 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.0625 0.187501" />
                            <Vertex pos="1 0.0625 -0.312505" />
                            <Vertex pos="1 -0.0625 0.312504" />
                            <Vertex pos="1 -0.0625 -0.187502" />
                            <Vertex pos="-1 0.0625 0.187501" />
                            <Vertex pos="-1 0.0625 -0.312505" />
                            <Vertex pos="-1 -0.0625 0.312504" />
                            <Vertex pos="-1 -0.0625 -0.187502" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -1" album="" material="bm_wood" texgens="0 1 0 -18832 0 0 -1 -1744 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_wood" texgens="0 -1 0 18832 0 0 -1 -1744 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 -7168 0 0 -1 -1744 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 7168 0 0 -1 -1744 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707115 0.707098 -0.176776" album="" material="bm_wood" texgens="1 0 0 7168 0 -1 0 18832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.707115 -0.707098 -0.176777" album="" material="bm_wood" texgens="-1 0 0 -7168 0 -1 0 18832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="231" owner="0" type="0" pos="32 -72.4375 6.8125" rot="1 0 0 0" scale="" transform="1 0 0 32 0 1 0 -72.4375 0 0 1 6.8125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.0625 0.312499" />
                            <Vertex pos="1 0.0625 -0.187501" />
                            <Vertex pos="1 -0.0625 0.187502" />
                            <Vertex pos="1 -0.0625 -0.312499" />
                            <Vertex pos="-1 0.0625 0.312499" />
                            <Vertex pos="-1 0.0625 -0.187501" />
                            <Vertex pos="-1 -0.0625 0.187502" />
                            <Vertex pos="-1 -0.0625 -0.312499" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_wood" texgens="0 1 0 -18544 0 0 -1 -1744 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -1" album="" material="bm_wood" texgens="0 -1 0 18544 0 0 -1 -1744 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 -8192 0 0 -1 -1744 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 8192 0 0 -1 -1744 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707098 0.707115 -0.176779" album="" material="bm_wood" texgens="1 0 0 8192 0 -1 0 18544 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.707101 -0.707112 -0.176778" album="" material="bm_wood" texgens="-1 0 0 -8192 0 -1 0 18544 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="232" owner="0" type="0" pos="32 -73.5625 6.81251" rot="1 0 0 0" scale="" transform="1 0 0 32 0 1 0 -73.5625 0 0 1 6.81251 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.0625 0.187501" />
                            <Vertex pos="1 0.0625 -0.312505" />
                            <Vertex pos="1 -0.0625 0.312504" />
                            <Vertex pos="1 -0.0625 -0.187502" />
                            <Vertex pos="-1 0.0625 0.187501" />
                            <Vertex pos="-1 0.0625 -0.312505" />
                            <Vertex pos="-1 -0.0625 0.312504" />
                            <Vertex pos="-1 -0.0625 -0.187502" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -1" album="" material="bm_wood" texgens="0 1 0 -18832 0 0 -1 -1744 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_wood" texgens="0 -1 0 18832 0 0 -1 -1744 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 -8192 0 0 -1 -1744 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 8192 0 0 -1 -1744 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707115 0.707098 -0.176776" album="" material="bm_wood" texgens="1 0 0 8192 0 -1 0 18832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.707115 -0.707098 -0.176777" album="" material="bm_wood" texgens="-1 0 0 -8192 0 -1 0 18832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="233" owner="2" type="999" pos="30 -69.5 8" rot="1 0 0 0" scale="" transform="1 0 0 30 0 1 0 -69.5 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 1" />
                            <Vertex pos="1 1 -1" />
                            <Vertex pos="1 -1 1" />
                            <Vertex pos="1 -1 -1" />
                            <Vertex pos="-1 1 1" />
                            <Vertex pos="-1 1 -1" />
                            <Vertex pos="-1 -1 1" />
                            <Vertex pos="-1 -1 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_basher" texgens="0 1 0 256 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_basher" texgens="0 -1 0 256 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_basher_side" texgens="-1 0 0 256 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_basher_side" texgens="1 0 0 256 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_basher_top" texgens="1 0 0 256 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_basher_top" texgens="-1 0 0 256 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="234" owner="0" type="0" pos="25.25 -80 6.75" rot="1 0 0 0" scale="" transform="1 0 0 25.25 0 1 0 -80 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.25" />
                            <Vertex pos="0.25 2 -0.25" />
                            <Vertex pos="0.25 -2 0.25" />
                            <Vertex pos="0.25 -2 -0.25" />
                            <Vertex pos="-0.25 2 0.25" />
                            <Vertex pos="-0.25 2 -0.25" />
                            <Vertex pos="-0.25 -2 0.25" />
                            <Vertex pos="-0.25 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1792 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 1920 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1920 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="235" owner="0" type="0" pos="24 -82.25 6.75" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 -82.25 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 0.25 0.25" />
                            <Vertex pos="1.5 0.25 -0.25" />
                            <Vertex pos="1.5 -0.25 0.25" />
                            <Vertex pos="1.5 -0.25 -0.25" />
                            <Vertex pos="-1.5 0.25 0.25" />
                            <Vertex pos="-1.5 0.25 -0.25" />
                            <Vertex pos="-1.5 -0.25 0.25" />
                            <Vertex pos="-1.5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.5" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1.5" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 768 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -640 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="236" owner="0" type="0" pos="22.75 -81.75 6.75" rot="1 0 0 0" scale="" transform="1 0 0 22.75 0 1 0 -81.75 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 0.25" />
                            <Vertex pos="0.25 0.25 -0.25" />
                            <Vertex pos="0.25 -0.25 0.25" />
                            <Vertex pos="0.25 -0.25 -0.25" />
                            <Vertex pos="-0.25 0.25 0.25" />
                            <Vertex pos="-0.25 0.25 -0.25" />
                            <Vertex pos="-0.25 -0.25 0.25" />
                            <Vertex pos="-0.25 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -2240 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 2368 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 2368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 2368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="237" owner="0" type="0" pos="22.75 -78.25 6.75" rot="1 0 0 0" scale="" transform="1 0 0 22.75 0 1 0 -78.25 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2.25 0.25" />
                            <Vertex pos="0.25 2.25 -0.25" />
                            <Vertex pos="0.25 -2.25 0.25" />
                            <Vertex pos="0.25 -2.25 -0.25" />
                            <Vertex pos="-0.25 2.25 0.25" />
                            <Vertex pos="-0.25 2.25 -0.25" />
                            <Vertex pos="-0.25 -2.25 0.25" />
                            <Vertex pos="-0.25 -2.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1728 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 1856 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 1856 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1856 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="238" owner="0" type="0" pos="23.5 -75.75 6.75" rot="1 0 0 0" scale="" transform="1 0 0 23.5 0 1 0 -75.75 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 0.25" />
                            <Vertex pos="1 0.25 -0.25" />
                            <Vertex pos="1 -0.25 0.25" />
                            <Vertex pos="1 -0.25 -0.25" />
                            <Vertex pos="-1 0.25 0.25" />
                            <Vertex pos="-1 0.25 -0.25" />
                            <Vertex pos="-1 -0.25 0.25" />
                            <Vertex pos="-1 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 896 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -768 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="239" owner="0" type="0" pos="26.5 -78.25 6.75" rot="1 0 0 0" scale="" transform="1 0 0 26.5 0 1 0 -78.25 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 0.25" />
                            <Vertex pos="1 0.25 -0.25" />
                            <Vertex pos="1 -0.25 0.25" />
                            <Vertex pos="1 -0.25 -0.25" />
                            <Vertex pos="-1 0.25 0.25" />
                            <Vertex pos="-1 0.25 -0.25" />
                            <Vertex pos="-1 -0.25 0.25" />
                            <Vertex pos="-1 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 896 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -768 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="240" owner="0" type="0" pos="27.25 -75.75 6.75" rot="1 0 0 0" scale="" transform="1 0 0 27.25 0 1 0 -75.75 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2.25 0.25" />
                            <Vertex pos="0.25 2.25 -0.25" />
                            <Vertex pos="0.25 -2.25 0.25" />
                            <Vertex pos="0.25 -2.25 -0.25" />
                            <Vertex pos="-0.25 2.25 0.25" />
                            <Vertex pos="-0.25 2.25 -0.25" />
                            <Vertex pos="-0.25 -2.25 0.25" />
                            <Vertex pos="-0.25 -2.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1728 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 1856 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 1856 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1856 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="241" owner="0" type="0" pos="24.75 -74 6.75" rot="1 0 0 0" scale="" transform="1 0 0 24.75 0 1 0 -74 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.25" />
                            <Vertex pos="0.25 2 -0.25" />
                            <Vertex pos="0.25 -2 0.25" />
                            <Vertex pos="0.25 -2 -0.25" />
                            <Vertex pos="-0.25 2 0.25" />
                            <Vertex pos="-0.25 2 -0.25" />
                            <Vertex pos="-0.25 -2 0.25" />
                            <Vertex pos="-0.25 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1792 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 1920 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1920 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="242" owner="0" type="0" pos="26 -71.75 6.75" rot="1 0 0 0" scale="" transform="1 0 0 26 0 1 0 -71.75 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 0.25 0.25" />
                            <Vertex pos="1.5 0.25 -0.25" />
                            <Vertex pos="1.5 -0.25 0.25" />
                            <Vertex pos="1.5 -0.25 -0.25" />
                            <Vertex pos="-1.5 0.25 0.25" />
                            <Vertex pos="-1.5 0.25 -0.25" />
                            <Vertex pos="-1.5 -0.25 0.25" />
                            <Vertex pos="-1.5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.5" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1.5" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 768 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -640 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="243" owner="0" type="0" pos="27.25 -72.25 6.75" rot="1 0 0 0" scale="" transform="1 0 0 27.25 0 1 0 -72.25 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 0.25" />
                            <Vertex pos="0.25 0.25 -0.25" />
                            <Vertex pos="0.25 -0.25 0.25" />
                            <Vertex pos="0.25 -0.25 -0.25" />
                            <Vertex pos="-0.25 0.25 0.25" />
                            <Vertex pos="-0.25 0.25 -0.25" />
                            <Vertex pos="-0.25 -0.25 0.25" />
                            <Vertex pos="-0.25 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -2240 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 2368 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 2368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 2368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="244" owner="0" type="0" pos="35 -71.75 6.75" rot="1 0 0 0" scale="" transform="1 0 0 35 0 1 0 -71.75 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 0.25" />
                            <Vertex pos="2 0.25 -0.25" />
                            <Vertex pos="2 -0.25 0.25" />
                            <Vertex pos="2 -0.25 -0.25" />
                            <Vertex pos="-2 0.25 0.25" />
                            <Vertex pos="-2 0.25 -0.25" />
                            <Vertex pos="-2 -0.25 0.25" />
                            <Vertex pos="-2 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 896 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -768 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="245" owner="0" type="0" pos="35 -74.25 6.75" rot="1 0 0 0" scale="" transform="1 0 0 35 0 1 0 -74.25 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 0.25" />
                            <Vertex pos="2 0.25 -0.25" />
                            <Vertex pos="2 -0.25 0.25" />
                            <Vertex pos="2 -0.25 -0.25" />
                            <Vertex pos="-2 0.25 0.25" />
                            <Vertex pos="-2 0.25 -0.25" />
                            <Vertex pos="-2 -0.25 0.25" />
                            <Vertex pos="-2 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 896 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -768 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="246" owner="0" type="0" pos="32.75 -74 6.75" rot="1 0 0 0" scale="" transform="1 0 0 32.75 0 1 0 -74 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.5 0.25" />
                            <Vertex pos="0.25 0.5 -0.25" />
                            <Vertex pos="0.25 -0.5 0.25" />
                            <Vertex pos="0.25 -0.5 -0.25" />
                            <Vertex pos="-0.25 0.5 0.25" />
                            <Vertex pos="-0.25 0.5 -0.25" />
                            <Vertex pos="-0.25 -0.5 0.25" />
                            <Vertex pos="-0.25 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1280 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="247" owner="0" type="0" pos="32.75 -72 6.75" rot="1 0 0 0" scale="" transform="1 0 0 32.75 0 1 0 -72 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.5 0.25" />
                            <Vertex pos="0.25 0.5 -0.25" />
                            <Vertex pos="0.25 -0.5 0.25" />
                            <Vertex pos="0.25 -0.5 -0.25" />
                            <Vertex pos="-0.25 0.5 0.25" />
                            <Vertex pos="-0.25 0.5 -0.25" />
                            <Vertex pos="-0.25 -0.5 0.25" />
                            <Vertex pos="-0.25 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1280 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="248" owner="0" type="0" pos="37.25 -73 6.75" rot="1 0 0 0" scale="" transform="1 0 0 37.25 0 1 0 -73 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1.5 0.25" />
                            <Vertex pos="0.25 1.5 -0.25" />
                            <Vertex pos="0.25 -1.5 0.25" />
                            <Vertex pos="0.25 -1.5 -0.25" />
                            <Vertex pos="-0.25 1.5 0.25" />
                            <Vertex pos="-0.25 1.5 -0.25" />
                            <Vertex pos="-0.25 -1.5 0.25" />
                            <Vertex pos="-0.25 -1.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.5" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 1664 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1664 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="249" owner="0" type="0" pos="21 -69.25 10.25" rot="1 0 0 0" scale="" transform="1 0 0 21 0 1 0 -69.25 0 0 1 10.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.25 0.25" />
                            <Vertex pos="6 0.25 -0.25" />
                            <Vertex pos="6 -0.25 0.25" />
                            <Vertex pos="6 -0.25 -0.25" />
                            <Vertex pos="-6 0.25 0.25" />
                            <Vertex pos="-6 0.25 -0.25" />
                            <Vertex pos="-6 -0.25 0.25" />
                            <Vertex pos="-6 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -384 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="250" owner="0" type="0" pos="21 -62.75 10.25" rot="1 0 0 0" scale="" transform="1 0 0 21 0 1 0 -62.75 0 0 1 10.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.25 0.25" />
                            <Vertex pos="6 0.25 -0.25" />
                            <Vertex pos="6 -0.25 0.25" />
                            <Vertex pos="6 -0.25 -0.25" />
                            <Vertex pos="-6 0.25 0.25" />
                            <Vertex pos="-6 0.25 -0.25" />
                            <Vertex pos="-6 -0.25 0.25" />
                            <Vertex pos="-6 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -384 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="251" owner="0" type="0" pos="27.25 -68.25 10.25" rot="1 0 0 0" scale="" transform="1 0 0 27.25 0 1 0 -68.25 0 0 1 10.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1.25 0.25" />
                            <Vertex pos="0.25 1.25 -0.25" />
                            <Vertex pos="0.25 -1.25 0.25" />
                            <Vertex pos="0.25 -1.25 -0.25" />
                            <Vertex pos="-0.25 1.25 0.25" />
                            <Vertex pos="-0.25 1.25 -0.25" />
                            <Vertex pos="-0.25 -1.25 0.25" />
                            <Vertex pos="-0.25 -1.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1472 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 1600 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="252" owner="0" type="0" pos="27.25 -63.75 10.25" rot="1 0 0 0" scale="" transform="1 0 0 27.25 0 1 0 -63.75 0 0 1 10.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1.25 0.25" />
                            <Vertex pos="0.25 1.25 -0.25" />
                            <Vertex pos="0.25 -1.25 0.25" />
                            <Vertex pos="0.25 -1.25 -0.25" />
                            <Vertex pos="-0.25 1.25 0.25" />
                            <Vertex pos="-0.25 1.25 -0.25" />
                            <Vertex pos="-0.25 -1.25 0.25" />
                            <Vertex pos="-0.25 -1.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1472 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 1600 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="253" owner="0" type="0" pos="-9 -69.25 10.25" rot="1 0 0 0" scale="" transform="1 0 0 -9 0 1 0 -69.25 0 0 1 10.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.25 0.25" />
                            <Vertex pos="6 0.25 -0.25" />
                            <Vertex pos="6 -0.25 0.25" />
                            <Vertex pos="6 -0.25 -0.25" />
                            <Vertex pos="-6 0.25 0.25" />
                            <Vertex pos="-6 0.25 -0.25" />
                            <Vertex pos="-6 -0.25 0.25" />
                            <Vertex pos="-6 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -384 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="254" owner="0" type="0" pos="-9 -62.75 10.25" rot="1 0 0 0" scale="" transform="1 0 0 -9 0 1 0 -62.75 0 0 1 10.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.25 0.25" />
                            <Vertex pos="6 0.25 -0.25" />
                            <Vertex pos="6 -0.25 0.25" />
                            <Vertex pos="6 -0.25 -0.25" />
                            <Vertex pos="-6 0.25 0.25" />
                            <Vertex pos="-6 0.25 -0.25" />
                            <Vertex pos="-6 -0.25 0.25" />
                            <Vertex pos="-6 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -384 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="255" owner="0" type="0" pos="-15.25 -63.25 10.25" rot="1 0 0 0" scale="" transform="1 0 0 -15.25 0 1 0 -63.25 0 0 1 10.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.75 0.25" />
                            <Vertex pos="0.25 0.75 -0.25" />
                            <Vertex pos="0.25 -0.75 0.25" />
                            <Vertex pos="0.25 -0.75 -0.25" />
                            <Vertex pos="-0.25 0.75 0.25" />
                            <Vertex pos="-0.25 0.75 -0.25" />
                            <Vertex pos="-0.25 -0.75 0.25" />
                            <Vertex pos="-0.25 -0.75 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1600 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 1728 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.75" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.75" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="256" owner="0" type="0" pos="-15.25 -68.75 10.25" rot="1 0 0 0" scale="" transform="1 0 0 -15.25 0 1 0 -68.75 0 0 1 10.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.75 0.25" />
                            <Vertex pos="0.25 0.75 -0.25" />
                            <Vertex pos="0.25 -0.75 0.25" />
                            <Vertex pos="0.25 -0.75 -0.25" />
                            <Vertex pos="-0.25 0.75 0.25" />
                            <Vertex pos="-0.25 0.75 -0.25" />
                            <Vertex pos="-0.25 -0.75 0.25" />
                            <Vertex pos="-0.25 -0.75 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1600 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 1728 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.75" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.75" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="257" owner="0" type="0" pos="-15.25 -66 10.25" rot="1 0 0 0" scale="" transform="1 0 0 -15.25 0 1 0 -66 0 0 1 10.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1 0.25" />
                            <Vertex pos="0.25 1 -0.25" />
                            <Vertex pos="0.25 -1 0.25" />
                            <Vertex pos="0.25 -1 -0.25" />
                            <Vertex pos="-0.25 1 0.25" />
                            <Vertex pos="-0.25 1 -0.25" />
                            <Vertex pos="-0.25 -1 0.25" />
                            <Vertex pos="-0.25 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 1664 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1664 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="258" owner="0" type="0" pos="-18 -63.9375 10.3125" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 -63.9375 0 0 1 10.3125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.0624962 0.312496" />
                            <Vertex pos="3 0.0624962 -0.187499" />
                            <Vertex pos="3 -0.0625 0.187498" />
                            <Vertex pos="3 -0.0625 -0.312496" />
                            <Vertex pos="-3 0.0624962 0.312496" />
                            <Vertex pos="-3 0.0624962 -0.187499" />
                            <Vertex pos="-3 -0.0625 0.187498" />
                            <Vertex pos="-3 -0.0625 -0.312496" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_wood" texgens="0 1 0 -16368 0 0 -1 -2640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -3" album="" material="bm_wood" texgens="0 -1 0 16368 0 0 -1 -2640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0624962" album="" material="bm_wood" texgens="-1 0 0 4608 0 0 -1 -2640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 -4608 0 0 -1 -2640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707112 0.707102 -0.176775" album="" material="bm_wood" texgens="1 0 0 -4608 0 -1 0 16368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.707109 -0.707105 -0.176773" album="" material="bm_wood" texgens="-1 0 0 4608 0 -1 0 16368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="259" owner="0" type="0" pos="-18 -65.0625 10.3125" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 -65.0625 0 0 1 10.3125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.0625 0.187499" />
                            <Vertex pos="3 0.0625 -0.312496" />
                            <Vertex pos="3 -0.0625 0.312496" />
                            <Vertex pos="3 -0.0625 -0.187498" />
                            <Vertex pos="-3 0.0625 0.187499" />
                            <Vertex pos="-3 0.0625 -0.312496" />
                            <Vertex pos="-3 -0.0625 0.312496" />
                            <Vertex pos="-3 -0.0625 -0.187498" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -3" album="" material="bm_wood" texgens="0 1 0 -16656 0 0 -1 -2640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_wood" texgens="0 -1 0 16656 0 0 -1 -2640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 4608 0 0 -1 -2640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 -4608 0 0 -1 -2640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707098 0.707115 -0.176777" album="" material="bm_wood" texgens="1 0 0 -4608 0 -1 0 16656 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.707101 -0.707112 -0.176776" album="" material="bm_wood" texgens="-1 0 0 4608 0 -1 0 16656 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="260" owner="0" type="0" pos="-18 -66.9375 10.3125" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 -66.9375 0 0 1 10.3125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.0625 0.312496" />
                            <Vertex pos="3 0.0625 -0.1875" />
                            <Vertex pos="3 -0.0625 0.187531" />
                            <Vertex pos="3 -0.0625 -0.312497" />
                            <Vertex pos="-3 0.0625 0.312496" />
                            <Vertex pos="-3 0.0625 -0.1875" />
                            <Vertex pos="-3 -0.0625 0.187531" />
                            <Vertex pos="-3 -0.0625 -0.312497" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_wood" texgens="0 1 0 -17136 0 0 -1 -2640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -3" album="" material="bm_wood" texgens="0 -1 0 17136 0 0 -1 -2640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 4608 0 0 -1 -2640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 -4608 0 0 -1 -2640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707008 0.707206 -0.176811" album="" material="bm_wood" texgens="1 0 0 -4608 0 -1 0 17136 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.707098 -0.707115 -0.176778" album="" material="bm_wood" texgens="-1 0 0 4608 0 -1 0 17136 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="261" owner="0" type="0" pos="-18 -68.0625 10.3125" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 -68.0625 0 0 1 10.3125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.0625 0.187499" />
                            <Vertex pos="3 0.0625 -0.312502" />
                            <Vertex pos="3 -0.0625 0.312501" />
                            <Vertex pos="3 -0.0625 -0.187499" />
                            <Vertex pos="-3 0.0625 0.187499" />
                            <Vertex pos="-3 0.0625 -0.312502" />
                            <Vertex pos="-3 -0.0625 0.312501" />
                            <Vertex pos="-3 -0.0625 -0.187499" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -3" album="" material="bm_wood" texgens="0 1 0 -17424 0 0 -1 -2640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_wood" texgens="0 -1 0 17424 0 0 -1 -2640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 4608 0 0 -1 -2640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 -4608 0 0 -1 -2640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707112 0.707101 -0.176775" album="" material="bm_wood" texgens="1 0 0 -4608 0 -1 0 17424 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.707115 -0.707098 -0.176775" album="" material="bm_wood" texgens="-1 0 0 4608 0 -1 0 17424 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="262" owner="0" type="0" pos="-66 -63.9375 10.3125" rot="1 0 0 0" scale="" transform="1 0 0 -66 0 1 0 -63.9375 0 0 1 10.3125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.0624962 0.312496" />
                            <Vertex pos="3 0.0624962 -0.187499" />
                            <Vertex pos="3 -0.0625 0.187498" />
                            <Vertex pos="3 -0.0625 -0.312496" />
                            <Vertex pos="-3 0.0624962 0.312496" />
                            <Vertex pos="-3 0.0624962 -0.187499" />
                            <Vertex pos="-3 -0.0625 0.187498" />
                            <Vertex pos="-3 -0.0625 -0.312496" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_wood" texgens="0 1 0 -16368 0 0 -1 -2640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -3" album="" material="bm_wood" texgens="0 -1 0 16368 0 0 -1 -2640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0624962" album="" material="bm_wood" texgens="-1 0 0 16896 0 0 -1 -2640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 -16896 0 0 -1 -2640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707112 0.707102 -0.176775" album="" material="bm_wood" texgens="1 0 0 -16896 0 -1 0 16368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.707109 -0.707105 -0.176773" album="" material="bm_wood" texgens="-1 0 0 16896 0 -1 0 16368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="263" owner="0" type="0" pos="-66 -65.0625 10.3125" rot="1 0 0 0" scale="" transform="1 0 0 -66 0 1 0 -65.0625 0 0 1 10.3125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.0625 0.187499" />
                            <Vertex pos="3 0.0625 -0.312496" />
                            <Vertex pos="3 -0.0625 0.312496" />
                            <Vertex pos="3 -0.0625 -0.187498" />
                            <Vertex pos="-3 0.0625 0.187499" />
                            <Vertex pos="-3 0.0625 -0.312496" />
                            <Vertex pos="-3 -0.0625 0.312496" />
                            <Vertex pos="-3 -0.0625 -0.187498" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -3" album="" material="bm_wood" texgens="0 1 0 -16656 0 0 -1 -2640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_wood" texgens="0 -1 0 16656 0 0 -1 -2640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 16896 0 0 -1 -2640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 -16896 0 0 -1 -2640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707098 0.707115 -0.176777" album="" material="bm_wood" texgens="1 0 0 -16896 0 -1 0 16656 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.707101 -0.707112 -0.176776" album="" material="bm_wood" texgens="-1 0 0 16896 0 -1 0 16656 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="264" owner="0" type="0" pos="-66 -66.9375 10.3125" rot="1 0 0 0" scale="" transform="1 0 0 -66 0 1 0 -66.9375 0 0 1 10.3125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.0625 0.312496" />
                            <Vertex pos="3 0.0625 -0.1875" />
                            <Vertex pos="3 -0.0625 0.187531" />
                            <Vertex pos="3 -0.0625 -0.312497" />
                            <Vertex pos="-3 0.0625 0.312496" />
                            <Vertex pos="-3 0.0625 -0.1875" />
                            <Vertex pos="-3 -0.0625 0.187531" />
                            <Vertex pos="-3 -0.0625 -0.312497" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_wood" texgens="0 1 0 -17136 0 0 -1 -2640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -3" album="" material="bm_wood" texgens="0 -1 0 17136 0 0 -1 -2640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 16896 0 0 -1 -2640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 -16896 0 0 -1 -2640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707008 0.707206 -0.176811" album="" material="bm_wood" texgens="1 0 0 -16896 0 -1 0 17136 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.707098 -0.707115 -0.176778" album="" material="bm_wood" texgens="-1 0 0 16896 0 -1 0 17136 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="265" owner="0" type="0" pos="-66 -68.0625 10.3125" rot="1 0 0 0" scale="" transform="1 0 0 -66 0 1 0 -68.0625 0 0 1 10.3125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.0625 0.187499" />
                            <Vertex pos="3 0.0625 -0.312502" />
                            <Vertex pos="3 -0.0625 0.312501" />
                            <Vertex pos="3 -0.0625 -0.187499" />
                            <Vertex pos="-3 0.0625 0.187499" />
                            <Vertex pos="-3 0.0625 -0.312502" />
                            <Vertex pos="-3 -0.0625 0.312501" />
                            <Vertex pos="-3 -0.0625 -0.187499" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -3" album="" material="bm_wood" texgens="0 1 0 -17424 0 0 -1 -2640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_wood" texgens="0 -1 0 17424 0 0 -1 -2640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 16896 0 0 -1 -2640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 -16896 0 0 -1 -2640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707112 0.707101 -0.176775" album="" material="bm_wood" texgens="1 0 0 -16896 0 -1 0 17424 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.707115 -0.707098 -0.176775" album="" material="bm_wood" texgens="-1 0 0 16896 0 -1 0 17424 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="266" owner="0" type="0" pos="-62.5 -63.9375 10.4375" rot="1 0 0 0" scale="" transform="1 0 0 -62.5 0 1 0 -63.9375 0 0 1 10.4375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.0625 0.437499" />
                            <Vertex pos="0.5 0.0625 -0.0624971" />
                            <Vertex pos="0.5 -0.0625 0.312497" />
                            <Vertex pos="0.5 -0.0625 -0.187498" />
                            <Vertex pos="-0.5 0.0625 0.187499" />
                            <Vertex pos="-0.5 0.0625 -0.312497" />
                            <Vertex pos="-0.5 -0.0625 0.0624971" />
                            <Vertex pos="-0.5 -0.0625 -0.437498" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_wood" texgens="0 1 0 -16368 0 0 -1 -2672 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.5" album="" material="bm_wood" texgens="0 -1 0 16368 0 0 -1 -2672 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 16000 0 0 -1 -2672 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 -16000 0 0 -1 -2672 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.174076 -0.696316 0.696305 -0.174075" album="" material="bm_wood" texgens="1 0 0 -16000 0 -1 0 16368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.174077 0.696313 -0.696308 -0.174075" album="" material="bm_wood" texgens="-1 0 0 16000 0 -1 0 16368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="267" owner="0" type="0" pos="-62.5 -65.0625 10.4375" rot="1 0 0 0" scale="" transform="1 0 0 -62.5 0 1 0 -65.0625 0 0 1 10.4375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.0625 0.312496" />
                            <Vertex pos="0.5 0.0625 -0.187493" />
                            <Vertex pos="0.5 -0.0625 0.437492" />
                            <Vertex pos="0.5 -0.0625 -0.0624971" />
                            <Vertex pos="-0.5 0.0625 0.0624962" />
                            <Vertex pos="-0.5 0.0625 -0.437493" />
                            <Vertex pos="-0.5 -0.0625 0.187492" />
                            <Vertex pos="-0.5 -0.0625 -0.312497" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.5" album="" material="bm_wood" texgens="0 1 0 -16656 0 0 -1 -2672 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_wood" texgens="0 -1 0 16656 0 0 -1 -2672 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 16000 0 0 -1 -2672 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 -16000 0 0 -1 -2672 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.17408 0.696299 0.696322 -0.174076" album="" material="bm_wood" texgens="1 0 0 -16000 0 -1 0 16656 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.17408 -0.696299 -0.696322 -0.174077" album="" material="bm_wood" texgens="-1 0 0 16000 0 -1 0 16656 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="268" owner="0" type="0" pos="-62.5 -66.9375 10.4375" rot="1 0 0 0" scale="" transform="1 0 0 -62.5 0 1 0 -66.9375 0 0 1 10.4375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.0625 0.437505" />
                            <Vertex pos="0.5 0.0625 -0.0625019" />
                            <Vertex pos="0.5 -0.0625 0.312503" />
                            <Vertex pos="0.5 -0.0625 -0.187504" />
                            <Vertex pos="-0.5 0.0625 0.187505" />
                            <Vertex pos="-0.5 0.0625 -0.312502" />
                            <Vertex pos="-0.5 -0.0625 0.0625029" />
                            <Vertex pos="-0.5 -0.0625 -0.437504" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_wood" texgens="0 1 0 -17136 0 0 -1 -2672 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.5" album="" material="bm_wood" texgens="0 -1 0 17136 0 0 -1 -2672 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 16000 0 0 -1 -2672 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 -16000 0 0 -1 -2672 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.174076 -0.696317 0.696305 -0.174079" album="" material="bm_wood" texgens="1 0 0 -16000 0 -1 0 17136 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.174076 0.696317 -0.696305 -0.174078" album="" material="bm_wood" texgens="-1 0 0 16000 0 -1 0 17136 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="269" owner="0" type="0" pos="-62.5 -68.0625 10.4375" rot="1 0 0 0" scale="" transform="1 0 0 -62.5 0 1 0 -68.0625 0 0 1 10.4375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.0625 0.312495" />
                            <Vertex pos="0.5 0.0625 -0.187491" />
                            <Vertex pos="0.5 -0.0625 0.437491" />
                            <Vertex pos="0.5 -0.0625 -0.0624952" />
                            <Vertex pos="-0.5 0.0625 0.0624952" />
                            <Vertex pos="-0.5 0.0625 -0.437491" />
                            <Vertex pos="-0.5 -0.0625 0.187491" />
                            <Vertex pos="-0.5 -0.0625 -0.312495" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.5" album="" material="bm_wood" texgens="0 1 0 -17424 0 0 -1 -2672 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_wood" texgens="0 -1 0 17424 0 0 -1 -2672 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 16000 0 0 -1 -2672 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 -16000 0 0 -1 -2672 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.17408 0.696299 0.696322 -0.174076" album="" material="bm_wood" texgens="1 0 0 -16000 0 -1 0 17424 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.17408 -0.696299 -0.696322 -0.174076" album="" material="bm_wood" texgens="-1 0 0 16000 0 -1 0 17424 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="270" owner="0" type="0" pos="-61.5 -63.9375 10.8125" rot="1 0 0 0" scale="" transform="1 0 0 -61.5 0 1 0 -63.9375 0 0 1 10.8125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.0624962 0.562495" />
                            <Vertex pos="0.5 0.0624962 0.0625029" />
                            <Vertex pos="0.5 -0.0625 0.437497" />
                            <Vertex pos="0.5 -0.0625 -0.0624952" />
                            <Vertex pos="-0.5 0.0624962 0.0624952" />
                            <Vertex pos="-0.5 0.0624962 -0.437497" />
                            <Vertex pos="-0.5 -0.0625 -0.0625029" />
                            <Vertex pos="-0.5 -0.0625 -0.562495" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_wood" texgens="0 1 0 -16368 0 0 -1 -2768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.5" album="" material="bm_wood" texgens="0 -1 0 16368 0 0 -1 -2768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0624962" album="" material="bm_wood" texgens="-1 0 0 15744 0 0 -1 -2768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 -15744 0 0 -1 -2768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.333331 -0.666672 0.666662 -0.166664" album="" material="bm_wood" texgens="1 0 0 -15744 0 -1 0 16368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.333331 0.666672 -0.666662 -0.166662" album="" material="bm_wood" texgens="-1 0 0 15744 0 -1 0 16368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="271" owner="0" type="0" pos="-61.5 -65.0625 10.8125" rot="1 0 0 0" scale="" transform="1 0 0 -61.5 0 1 0 -65.0625 0 0 1 10.8125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.0625 0.437503" />
                            <Vertex pos="0.5 0.0625 -0.062501" />
                            <Vertex pos="0.5 -0.0625 0.562501" />
                            <Vertex pos="0.5 -0.0625 0.0624971" />
                            <Vertex pos="-0.5 0.0625 -0.0624971" />
                            <Vertex pos="-0.5 0.0625 -0.562501" />
                            <Vertex pos="-0.5 -0.0625 0.062501" />
                            <Vertex pos="-0.5 -0.0625 -0.437503" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.5" album="" material="bm_wood" texgens="0 1 0 -16656 0 0 -1 -2768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_wood" texgens="0 -1 0 16656 0 0 -1 -2768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 15744 0 0 -1 -2768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 -15744 0 0 -1 -2768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.333336 0.666661 0.666671 -0.166669" album="" material="bm_wood" texgens="1 0 0 -15744 0 -1 0 16656 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.333336 -0.666661 -0.666671 -0.166669" album="" material="bm_wood" texgens="-1 0 0 15744 0 -1 0 16656 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="272" owner="0" type="0" pos="-61.5 -66.9375 10.8125" rot="1 0 0 0" scale="" transform="1 0 0 -61.5 0 1 0 -66.9375 0 0 1 10.8125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.0625 0.562501" />
                            <Vertex pos="0.5 0.0625 0.0624971" />
                            <Vertex pos="0.5 -0.0625 0.437503" />
                            <Vertex pos="0.5 -0.0625 -0.062501" />
                            <Vertex pos="-0.5 0.0625 0.062501" />
                            <Vertex pos="-0.5 0.0625 -0.437503" />
                            <Vertex pos="-0.5 -0.0625 -0.0624971" />
                            <Vertex pos="-0.5 -0.0625 -0.562501" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_wood" texgens="0 1 0 -17136 0 0 -1 -2768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.5" album="" material="bm_wood" texgens="0 -1 0 17136 0 0 -1 -2768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 15744 0 0 -1 -2768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 -15744 0 0 -1 -2768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.333336 -0.666661 0.666671 -0.166669" album="" material="bm_wood" texgens="1 0 0 -15744 0 -1 0 17136 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.333336 0.666661 -0.666671 -0.166669" album="" material="bm_wood" texgens="-1 0 0 15744 0 -1 0 17136 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="273" owner="0" type="0" pos="-61.5 -68.0625 10.8125" rot="1 0 0 0" scale="" transform="1 0 0 -61.5 0 1 0 -68.0625 0 0 1 10.8125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.0625 0.437501" />
                            <Vertex pos="0.5 0.0625 -0.0625" />
                            <Vertex pos="0.5 -0.0625 0.562499" />
                            <Vertex pos="0.5 -0.0625 0.0624981" />
                            <Vertex pos="-0.5 0.0625 -0.062499" />
                            <Vertex pos="-0.5 0.0625 -0.5625" />
                            <Vertex pos="-0.5 -0.0625 0.062499" />
                            <Vertex pos="-0.5 -0.0625 -0.437502" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.5" album="" material="bm_wood" texgens="0 1 0 -17424 0 0 -1 -2768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_wood" texgens="0 -1 0 17424 0 0 -1 -2768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 15744 0 0 -1 -2768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 -15744 0 0 -1 -2768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.333336 0.666661 0.666671 -0.166668" album="" material="bm_wood" texgens="1 0 0 -15744 0 -1 0 17424 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.333336 -0.666661 -0.666671 -0.166668" album="" material="bm_wood" texgens="-1 0 0 15744 0 -1 0 17424 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="274" owner="0" type="0" pos="-22.5 -63.9375 10.8125" rot="1 0 0 0" scale="" transform="1 0 0 -22.5 0 1 0 -63.9375 0 0 1 10.8125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.0624962 0.0624981" />
                            <Vertex pos="0.5 0.0624962 -0.4375" />
                            <Vertex pos="0.5 -0.0625 -0.0625" />
                            <Vertex pos="0.5 -0.0625 -0.562498" />
                            <Vertex pos="-0.5 0.0624962 0.562498" />
                            <Vertex pos="-0.5 0.0624962 0.0625" />
                            <Vertex pos="-0.5 -0.0625 0.4375" />
                            <Vertex pos="-0.5 -0.0625 -0.0624981" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_wood" texgens="0 1 0 -16368 0 0 -1 -2768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.5" album="" material="bm_wood" texgens="0 -1 0 16368 0 0 -1 -2768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0624962" album="" material="bm_wood" texgens="-1 0 0 5760 0 0 -1 -2768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 -5760 0 0 -1 -2768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.333331 -0.666672 0.666662 -0.166666" album="" material="bm_wood" texgens="1 0 0 -5760 0 -1 0 16368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.333331 0.666672 -0.666662 -0.166664" album="" material="bm_wood" texgens="-1 0 0 5760 0 -1 0 16368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="275" owner="0" type="0" pos="-22.5 -65.0625 10.8125" rot="1 0 0 0" scale="" transform="1 0 0 -22.5 0 1 0 -65.0625 0 0 1 10.8125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.0625 -0.0625057" />
                            <Vertex pos="0.5 0.0625 -0.562492" />
                            <Vertex pos="0.5 -0.0625 0.0624924" />
                            <Vertex pos="0.5 -0.0625 -0.437494" />
                            <Vertex pos="-0.5 0.0625 0.437494" />
                            <Vertex pos="-0.5 0.0625 -0.0624924" />
                            <Vertex pos="-0.5 -0.0625 0.562492" />
                            <Vertex pos="-0.5 -0.0625 0.0625057" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.5" album="" material="bm_wood" texgens="0 1 0 -16656 0 0 -1 -2768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_wood" texgens="0 -1 0 16656 0 0 -1 -2768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 5760 0 0 -1 -2768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 -5760 0 0 -1 -2768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.333336 0.666661 0.666671 -0.166663" album="" material="bm_wood" texgens="1 0 0 -5760 0 -1 0 16656 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.333336 -0.666661 -0.666671 -0.166663" album="" material="bm_wood" texgens="-1 0 0 5760 0 -1 0 16656 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="276" owner="0" type="0" pos="-22.5 -66.9375 10.8125" rot="1 0 0 0" scale="" transform="1 0 0 -22.5 0 1 0 -66.9375 0 0 1 10.8125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.0625 0.0624952" />
                            <Vertex pos="0.5 0.0625 -0.437497" />
                            <Vertex pos="0.5 -0.0625 -0.0625029" />
                            <Vertex pos="0.5 -0.0625 -0.562495" />
                            <Vertex pos="-0.5 0.0625 0.562495" />
                            <Vertex pos="-0.5 0.0625 0.0625029" />
                            <Vertex pos="-0.5 -0.0625 0.437497" />
                            <Vertex pos="-0.5 -0.0625 -0.0624952" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_wood" texgens="0 1 0 -17136 0 0 -1 -2768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.5" album="" material="bm_wood" texgens="0 -1 0 17136 0 0 -1 -2768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 5760 0 0 -1 -2768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 -5760 0 0 -1 -2768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.333336 -0.666661 0.666671 -0.166665" album="" material="bm_wood" texgens="1 0 0 -5760 0 -1 0 17136 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.333336 0.666661 -0.666671 -0.166665" album="" material="bm_wood" texgens="-1 0 0 5760 0 -1 0 17136 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="277" owner="0" type="0" pos="-22.5 -68.0625 10.8125" rot="1 0 0 0" scale="" transform="1 0 0 -22.5 0 1 0 -68.0625 0 0 1 10.8125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.0625 -0.0625029" />
                            <Vertex pos="0.5 0.0625 -0.562495" />
                            <Vertex pos="0.5 -0.0625 0.0624952" />
                            <Vertex pos="0.5 -0.0625 -0.437497" />
                            <Vertex pos="-0.5 0.0625 0.437497" />
                            <Vertex pos="-0.5 0.0625 -0.0624952" />
                            <Vertex pos="-0.5 -0.0625 0.562495" />
                            <Vertex pos="-0.5 -0.0625 0.0625029" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.5" album="" material="bm_wood" texgens="0 1 0 -17424 0 0 -1 -2768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_wood" texgens="0 -1 0 17424 0 0 -1 -2768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 5760 0 0 -1 -2768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 -5760 0 0 -1 -2768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.333336 0.666661 0.666671 -0.166665" album="" material="bm_wood" texgens="1 0 0 -5760 0 -1 0 17424 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.333336 -0.666661 -0.666671 -0.166665" album="" material="bm_wood" texgens="-1 0 0 5760 0 -1 0 17424 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="278" owner="0" type="0" pos="-21.5 -63.9375 10.4375" rot="1 0 0 0" scale="" transform="1 0 0 -21.5 0 1 0 -63.9375 0 0 1 10.4375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.0625 0.187502" />
                            <Vertex pos="0.5 0.0625 -0.312499" />
                            <Vertex pos="0.5 -0.0625 0.0625" />
                            <Vertex pos="0.5 -0.0625 -0.437501" />
                            <Vertex pos="-0.5 0.0625 0.437502" />
                            <Vertex pos="-0.5 0.0625 -0.062499" />
                            <Vertex pos="-0.5 -0.0625 0.3125" />
                            <Vertex pos="-0.5 -0.0625 -0.187501" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_wood" texgens="0 1 0 -16368 0 0 -1 -2672 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.5" album="" material="bm_wood" texgens="0 -1 0 16368 0 0 -1 -2672 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 5504 0 0 -1 -2672 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 -5504 0 0 -1 -2672 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.174076 -0.696316 0.696305 -0.174077" album="" material="bm_wood" texgens="1 0 0 -5504 0 -1 0 16368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.174076 0.696316 -0.696305 -0.174076" album="" material="bm_wood" texgens="-1 0 0 5504 0 -1 0 16368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="279" owner="0" type="0" pos="-21.5 -65.0625 10.4375" rot="1 0 0 0" scale="" transform="1 0 0 -21.5 0 1 0 -65.0625 0 0 1 10.4375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.0625 0.0625019" />
                            <Vertex pos="0.5 0.0625 -0.437499" />
                            <Vertex pos="0.5 -0.0625 0.187498" />
                            <Vertex pos="0.5 -0.0625 -0.312503" />
                            <Vertex pos="-0.5 0.0625 0.312502" />
                            <Vertex pos="-0.5 0.0625 -0.187499" />
                            <Vertex pos="-0.5 -0.0625 0.437498" />
                            <Vertex pos="-0.5 -0.0625 -0.0625029" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.5" album="" material="bm_wood" texgens="0 1 0 -16656 0 0 -1 -2672 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_wood" texgens="0 -1 0 16656 0 0 -1 -2672 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 5504 0 0 -1 -2672 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 -5504 0 0 -1 -2672 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.17408 0.696299 0.696321 -0.17408" album="" material="bm_wood" texgens="1 0 0 -5504 0 -1 0 16656 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.17408 -0.696299 -0.696321 -0.174081" album="" material="bm_wood" texgens="-1 0 0 5504 0 -1 0 16656 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="280" owner="0" type="0" pos="-21.5 -66.9375 10.4375" rot="1 0 0 0" scale="" transform="1 0 0 -21.5 0 1 0 -66.9375 0 0 1 10.4375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.0625 0.187501" />
                            <Vertex pos="0.5 0.0625 -0.3125" />
                            <Vertex pos="0.5 -0.0625 0.0625" />
                            <Vertex pos="0.5 -0.0625 -0.437501" />
                            <Vertex pos="-0.5 0.0625 0.437501" />
                            <Vertex pos="-0.5 0.0625 -0.0625" />
                            <Vertex pos="-0.5 -0.0625 0.3125" />
                            <Vertex pos="-0.5 -0.0625 -0.187501" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_wood" texgens="0 1 0 -17136 0 0 -1 -2672 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.5" album="" material="bm_wood" texgens="0 -1 0 17136 0 0 -1 -2672 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 5504 0 0 -1 -2672 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 -5504 0 0 -1 -2672 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.174077 -0.696314 0.696308 -0.174077" album="" material="bm_wood" texgens="1 0 0 -5504 0 -1 0 17136 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.174077 0.696314 -0.696308 -0.174077" album="" material="bm_wood" texgens="-1 0 0 5504 0 -1 0 17136 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="281" owner="0" type="0" pos="-21.5 -68.0625 10.4375" rot="1 0 0 0" scale="" transform="1 0 0 -21.5 0 1 0 -68.0625 0 0 1 10.4375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.0625 0.0625" />
                            <Vertex pos="0.5 0.0625 -0.437495" />
                            <Vertex pos="0.5 -0.0625 0.187496" />
                            <Vertex pos="0.5 -0.0625 -0.312499" />
                            <Vertex pos="-0.5 0.0625 0.3125" />
                            <Vertex pos="-0.5 0.0625 -0.187495" />
                            <Vertex pos="-0.5 -0.0625 0.437496" />
                            <Vertex pos="-0.5 -0.0625 -0.062499" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.5" album="" material="bm_wood" texgens="0 1 0 -17424 0 0 -1 -2672 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_wood" texgens="0 -1 0 17424 0 0 -1 -2672 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 5504 0 0 -1 -2672 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 -5504 0 0 -1 -2672 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.17408 0.696299 0.696321 -0.174079" album="" material="bm_wood" texgens="1 0 0 -5504 0 -1 0 17424 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.17408 -0.696299 -0.696321 -0.174078" album="" material="bm_wood" texgens="-1 0 0 5504 0 -1 0 17424 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="282" owner="0" type="0" pos="-68.75 -63.25 10.25" rot="1 0 0 0" scale="" transform="1 0 0 -68.75 0 1 0 -63.25 0 0 1 10.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.75 0.25" />
                            <Vertex pos="0.25 0.75 -0.25" />
                            <Vertex pos="0.25 -0.75 0.25" />
                            <Vertex pos="0.25 -0.75 -0.25" />
                            <Vertex pos="-0.25 0.75 0.25" />
                            <Vertex pos="-0.25 0.75 -0.25" />
                            <Vertex pos="-0.25 -0.75 0.25" />
                            <Vertex pos="-0.25 -0.75 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1600 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 1728 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.75" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.75" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="283" owner="0" type="0" pos="-68.75 -68.75 10.25" rot="1 0 0 0" scale="" transform="1 0 0 -68.75 0 1 0 -68.75 0 0 1 10.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.75 0.25" />
                            <Vertex pos="0.25 0.75 -0.25" />
                            <Vertex pos="0.25 -0.75 0.25" />
                            <Vertex pos="0.25 -0.75 -0.25" />
                            <Vertex pos="-0.25 0.75 0.25" />
                            <Vertex pos="-0.25 0.75 -0.25" />
                            <Vertex pos="-0.25 -0.75 0.25" />
                            <Vertex pos="-0.25 -0.75 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1600 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 1728 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.75" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.75" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="284" owner="0" type="0" pos="-68.75 -66 10.25" rot="1 0 0 0" scale="" transform="1 0 0 -68.75 0 1 0 -66 0 0 1 10.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1 0.25" />
                            <Vertex pos="0.25 1 -0.25" />
                            <Vertex pos="0.25 -1 0.25" />
                            <Vertex pos="0.25 -1 -0.25" />
                            <Vertex pos="-0.25 1 0.25" />
                            <Vertex pos="-0.25 1 -0.25" />
                            <Vertex pos="-0.25 -1 0.25" />
                            <Vertex pos="-0.25 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 1664 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1664 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="285" owner="0" type="0" pos="-78 -69.25 10.25" rot="1 0 0 0" scale="" transform="1 0 0 -78 0 1 0 -69.25 0 0 1 10.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="9 0.25 0.25" />
                            <Vertex pos="9 0.25 -0.25" />
                            <Vertex pos="9 -0.25 0.25" />
                            <Vertex pos="9 -0.25 -0.25" />
                            <Vertex pos="-9 0.25 0.25" />
                            <Vertex pos="-9 0.25 -0.25" />
                            <Vertex pos="-9 -0.25 0.25" />
                            <Vertex pos="-9 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -9" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -9" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1280 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1152 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1152 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1280 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="286" owner="0" type="0" pos="-78 -62.75 10.25" rot="1 0 0 0" scale="" transform="1 0 0 -78 0 1 0 -62.75 0 0 1 10.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="9 0.25 0.25" />
                            <Vertex pos="9 0.25 -0.25" />
                            <Vertex pos="9 -0.25 0.25" />
                            <Vertex pos="9 -0.25 -0.25" />
                            <Vertex pos="-9 0.25 0.25" />
                            <Vertex pos="-9 0.25 -0.25" />
                            <Vertex pos="-9 -0.25 0.25" />
                            <Vertex pos="-9 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -9" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -9" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1280 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1152 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1152 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1280 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="287" owner="0" type="0" pos="-113 -52.75 10.25" rot="1 0 0 0" scale="" transform="1 0 0 -113 0 1 0 -52.75 0 0 1 10.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.25 0.25" />
                            <Vertex pos="6 0.25 -0.25" />
                            <Vertex pos="6 -0.25 0.25" />
                            <Vertex pos="6 -0.25 -0.25" />
                            <Vertex pos="-6 0.25 0.25" />
                            <Vertex pos="-6 0.25 -0.25" />
                            <Vertex pos="-6 -0.25 0.25" />
                            <Vertex pos="-6 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -384 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="288" owner="0" type="0" pos="-110 -57.25 10.25" rot="1 0 0 0" scale="" transform="1 0 0 -110 0 1 0 -57.25 0 0 1 10.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 -1.75 0.25" />
                            <Vertex pos="3 -1.75 -0.25" />
                            <Vertex pos="3 -2.25 0.25" />
                            <Vertex pos="3 -2.25 -0.25" />
                            <Vertex pos="-3 2.25 0.25" />
                            <Vertex pos="-3 2.25 -0.25" />
                            <Vertex pos="-3 1.75 0.25" />
                            <Vertex pos="-3 1.75 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 -2368 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 2496 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.5547 0.83205 -0 -0.208013" album="" material="bm_edge_white" texgens="-1 0 0 -256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.5547 -0.83205 -0 -0.208013" album="" material="bm_edge_white" texgens="1 0 0 384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 768 -0.666667 -1 0 64.0012 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 768 -0.666667 -1 0 64.0012 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="289" owner="0" type="0" pos="-115.25 -55.25 10.25" rot="1 0 0 0" scale="" transform="1 0 0 -115.25 0 1 0 -55.25 0 0 1 10.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.25 0.25 0.25" />
                            <Vertex pos="2.25 0.25 -0.25" />
                            <Vertex pos="2.25 -0.25 0.25" />
                            <Vertex pos="2.25 -0.25 -0.25" />
                            <Vertex pos="-2.25 0.25 0.25" />
                            <Vertex pos="-2.25 0.25 -0.25" />
                            <Vertex pos="-2.25 -0.25 0.25" />
                            <Vertex pos="-2.25 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2.25" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.25" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -448 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 576 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 576 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -448 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="290" owner="0" type="0" pos="-118.75 -55.25 10.25" rot="1 0 0 0" scale="" transform="1 0 0 -118.75 0 1 0 -55.25 0 0 1 10.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 0.25" />
                            <Vertex pos="0.25 0.25 -0.25" />
                            <Vertex pos="0.25 -0.25 0.25" />
                            <Vertex pos="0.25 -0.25 -0.25" />
                            <Vertex pos="-0.25 0.25 0.25" />
                            <Vertex pos="-0.25 0.25 -0.25" />
                            <Vertex pos="-0.25 -0.25 0.25" />
                            <Vertex pos="-0.25 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -960 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1088 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1088 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -960 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="291" owner="0" type="0" pos="-119.25 -54 10.25" rot="1 0 0 0" scale="" transform="1 0 0 -119.25 0 1 0 -54 0 0 1 10.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1.5 0.25" />
                            <Vertex pos="0.25 1.5 -0.25" />
                            <Vertex pos="0.25 -1.5 0.25" />
                            <Vertex pos="0.25 -1.5 -0.25" />
                            <Vertex pos="-0.25 1.5 0.25" />
                            <Vertex pos="-0.25 1.5 -0.25" />
                            <Vertex pos="-0.25 -1.5 0.25" />
                            <Vertex pos="-0.25 -1.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -2560 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 2688 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1.5" album="" material="bm_edge_white" texgens="-1 0 0 -960 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.5" album="" material="bm_edge_white" texgens="1 0 0 1088 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1088 0 -1 0 2688 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -960 0 -1 0 2688 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="292" owner="0" type="0" pos="-118.563 -57.5 10.3125" rot="1 0 0 0" scale="" transform="1 0 0 -118.563 0 1 0 -57.5 0 0 1 10.3125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.0625 2.5 0.187516" />
                            <Vertex pos="0.0625 2.5 -0.312516" />
                            <Vertex pos="0.0625 -2.5 0.187516" />
                            <Vertex pos="0.0625 -2.5 -0.312516" />
                            <Vertex pos="-0.0625 2.5 0.312516" />
                            <Vertex pos="-0.0625 2.5 -0.187516" />
                            <Vertex pos="-0.0625 -2.5 0.312516" />
                            <Vertex pos="-0.0625 -2.5 -0.187516" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.0625" album="" material="bm_wood" texgens="0 1 0 -14720 0 0 -1 -2639.99 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.0625" album="" material="bm_wood" texgens="0 -1 0 14720 0 0 -1 -2639.99 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.5" album="" material="bm_wood" texgens="-1 0 0 30352 0 0 -1 -2639.99 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2.5" album="" material="bm_wood" texgens="1 0 0 -30352 0 0 -1 -2639.99 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -0.176788" album="" material="bm_wood" texgens="1 0 0 -30352 0 -1 0 14720 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 0 -0.707107 -0.176788" album="" material="bm_wood" texgens="-1 0 0 30352 0 -1 0 14720 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="293" owner="0" type="0" pos="-117.438 -57.5 10.3125" rot="1 0 0 0" scale="" transform="1 0 0 -117.438 0 1 0 -57.5 0 0 1 10.3125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.0625 2.5 0.3125" />
                            <Vertex pos="0.0625 2.5 -0.1875" />
                            <Vertex pos="0.0625 -2.5 0.3125" />
                            <Vertex pos="0.0625 -2.5 -0.1875" />
                            <Vertex pos="-0.0625 2.5 0.1875" />
                            <Vertex pos="-0.0625 2.5 -0.3125" />
                            <Vertex pos="-0.0625 -2.5 0.1875" />
                            <Vertex pos="-0.0625 -2.5 -0.3125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.0625" album="" material="bm_wood" texgens="0 1 0 -14720 0 0 -1 -2640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.0625" album="" material="bm_wood" texgens="0 -1 0 14720 0 0 -1 -2640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.5" album="" material="bm_wood" texgens="-1 0 0 30064 0 0 -1 -2640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2.5" album="" material="bm_wood" texgens="1 0 0 -30064 0 0 -1 -2640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -0.176777" album="" material="bm_wood" texgens="1 0 0 -30064 0 -1 0 14720 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -0.176777" album="" material="bm_wood" texgens="-1 0 0 30064 0 -1 0 14720 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="294" owner="0" type="0" pos="-118.563 -60.5 13.3125" rot="1 0 0 0" scale="" transform="1 0 0 -118.563 0 1 0 -60.5 0 0 1 13.3125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.0625 0.5 3.1875" />
                            <Vertex pos="0.0625 0.5 -3.3125" />
                            <Vertex pos="0.0625 -0.500004 3.1875" />
                            <Vertex pos="0.0625 -0.500004 -3.3125" />
                            <Vertex pos="-0.0625 0.5 3.3125" />
                            <Vertex pos="-0.0625 0.5 -3.1875" />
                            <Vertex pos="-0.0625 -0.500004 3.3125" />
                            <Vertex pos="-0.0625 -0.500004 -3.1875" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.0625" album="" material="bm_wood" texgens="0 1 0 -15488 0 0 -1 -3408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.0625" album="" material="bm_wood" texgens="0 -1 0 15488 0 0 -1 -3408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_wood" texgens="-1 0 0 30352 0 0 -1 -3408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.500004" album="" material="bm_wood" texgens="1 0 0 -30352 0 0 -1 -3408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -2.2981" album="" material="bm_wood" texgens="1 0 0 -30352 0 -1 0 15488 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 0 -0.707107 -2.2981" album="" material="bm_wood" texgens="-1 0 0 30352 0 -1 0 15488 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="295" owner="0" type="0" pos="-117.438 -60.5 13.3125" rot="1 0 0 0" scale="" transform="1 0 0 -117.438 0 1 0 -60.5 0 0 1 13.3125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.0625 0.5 3.3125" />
                            <Vertex pos="0.0625 0.5 -3.1875" />
                            <Vertex pos="0.0625 -0.500004 3.3125" />
                            <Vertex pos="0.0625 -0.500004 -3.1875" />
                            <Vertex pos="-0.0625 0.5 3.1875" />
                            <Vertex pos="-0.0625 0.5 -3.3125" />
                            <Vertex pos="-0.0625 -0.500004 3.1875" />
                            <Vertex pos="-0.0625 -0.500004 -3.3125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.0625" album="" material="bm_wood" texgens="0 1 0 -15488 0 0 -1 -3408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.0625" album="" material="bm_wood" texgens="0 -1 0 15488 0 0 -1 -3408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_wood" texgens="-1 0 0 30064 0 0 -1 -3408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.500004" album="" material="bm_wood" texgens="1 0 0 -30064 0 0 -1 -3408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -2.2981" album="" material="bm_wood" texgens="1 0 0 -30064 0 -1 0 15488 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -2.2981" album="" material="bm_wood" texgens="-1 0 0 30064 0 -1 0 15488 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="296" owner="0" type="0" pos="-118.563 -63 16.3125" rot="1 0 0 0" scale="" transform="1 0 0 -118.563 0 1 0 -63 0 0 1 16.3125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.0625 2 0.1875" />
                            <Vertex pos="0.0625 2 -0.3125" />
                            <Vertex pos="0.0625 -2 0.1875" />
                            <Vertex pos="0.0625 -2 -0.3125" />
                            <Vertex pos="-0.0625 2 0.3125" />
                            <Vertex pos="-0.0625 2 -0.1875" />
                            <Vertex pos="-0.0625 -2 0.3125" />
                            <Vertex pos="-0.0625 -2 -0.1875" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.0625" album="" material="bm_wood" texgens="0 1 0 -16128 0 0 -1 -4176 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.0625" album="" material="bm_wood" texgens="0 -1 0 16128 0 0 -1 -4176 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_wood" texgens="-1 0 0 30352 0 0 -1 -4176 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_wood" texgens="1 0 0 -30352 0 0 -1 -4176 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -0.176777" album="" material="bm_wood" texgens="1 0 0 -30352 0 -1 0 16128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 0 -0.707107 -0.176777" album="" material="bm_wood" texgens="-1 0 0 30352 0 -1 0 16128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="297" owner="0" type="0" pos="-117.438 -63 16.3125" rot="1 0 0 0" scale="" transform="1 0 0 -117.438 0 1 0 -63 0 0 1 16.3125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.0625 2 0.312494" />
                            <Vertex pos="0.0625 2 -0.187496" />
                            <Vertex pos="0.0625 -2 0.312494" />
                            <Vertex pos="0.0625 -2 -0.187496" />
                            <Vertex pos="-0.0625 2 0.187494" />
                            <Vertex pos="-0.0625 2 -0.312495" />
                            <Vertex pos="-0.0625 -2 0.187494" />
                            <Vertex pos="-0.0625 -2 -0.312495" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.0625" album="" material="bm_wood" texgens="0 1 0 -16128 0 0 -1 -4176 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.0625" album="" material="bm_wood" texgens="0 -1 0 16128 0 0 -1 -4176 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_wood" texgens="-1 0 0 30064 0 0 -1 -4176 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_wood" texgens="1 0 0 -30064 0 0 -1 -4176 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -0.176772" album="" material="bm_wood" texgens="1 0 0 -30064 0 -1 0 16128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707104 0 -0.70711 -0.176774" album="" material="bm_wood" texgens="-1 0 0 30064 0 -1 0 16128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="298" owner="0" type="0" pos="-100.563 -67.5 16.3125" rot="1 0 0 0" scale="" transform="1 0 0 -100.563 0 1 0 -67.5 0 0 1 16.3125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.0625 1 0.187502" />
                            <Vertex pos="0.0625 1 -0.312498" />
                            <Vertex pos="0.0625 -1 0.187502" />
                            <Vertex pos="0.0625 -1 -0.3125" />
                            <Vertex pos="-0.0625 0.875 0.312502" />
                            <Vertex pos="-0.0625 0.875 -0.187498" />
                            <Vertex pos="-0.0625 -1 0.312502" />
                            <Vertex pos="-0.0625 -1 -0.1875" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.0625" album="" material="bm_wood" texgens="0 1 0 -17280 0 0 -1 -4176 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.0625" album="" material="bm_wood" texgens="0 -1 0 17280 0 0 -1 -4176 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -0.662913" album="" material="bm_wood" texgens="-1 0 0 25744 0 0 -1 -4176 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_wood" texgens="1 0 0 -25744 0 0 -1 -4176 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -0.176778" album="" material="bm_wood" texgens="1 0 0 -25744 0 -1 0 17280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 7.0596e-007 -0.707107 -0.176776" album="" material="bm_wood" texgens="-1 0 0 25744 0 -1 0 17280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="299" owner="0" type="0" pos="-99.4375 -66.9375 16.3125" rot="1 0 0 0" scale="" transform="1 0 0 -99.4375 0 1 0 -66.9375 0 0 1 16.3125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.0625 1.5625 0.312504" />
                            <Vertex pos="0.0625 1.5625 -0.187508" />
                            <Vertex pos="0.0625 -1.5625 0.312502" />
                            <Vertex pos="0.0625 -1.5625 -0.187477" />
                            <Vertex pos="-0.0625 1.4375 0.187536" />
                            <Vertex pos="-0.0625 1.4375 -0.312506" />
                            <Vertex pos="-0.0625 -1.5625 0.187534" />
                            <Vertex pos="-0.0625 -1.5625 -0.312477" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.0625" album="" material="bm_wood" texgens="0 1 0 -17136 0 0 -1 -4176 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.0625" album="" material="bm_wood" texgens="0 -1 0 17136 0 0 -1 -4176 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -1.06066" album="" material="bm_wood" texgens="-1 0 0 25456 0 0 -1 -4176 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.5625" album="" material="bm_wood" texgens="1 0 0 -25456 0 0 -1 -4176 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707016 -4.707e-007 0.707197 -0.176813" album="" material="bm_wood" texgens="1 0 0 -25456 0 -1 0 17136 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 -7.01661e-006 -0.707107 -0.176771" album="" material="bm_wood" texgens="-1 0 0 25456 0 -1 0 17136 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="300" owner="0" type="0" pos="-101.938 -65.4375 16.3125" rot="1 0 0 0" scale="" transform="1 0 0 -101.938 0 1 0 -65.4375 0 0 1 16.3125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.5625 0.0625 0.312496" />
                            <Vertex pos="2.5625 0.0625 -0.18746" />
                            <Vertex pos="2.4375 -0.0625 0.187494" />
                            <Vertex pos="2.4375 -0.0625 -0.312494" />
                            <Vertex pos="-2.5625 0.0625 0.312496" />
                            <Vertex pos="-2.5625 0.0625 -0.18746" />
                            <Vertex pos="-2.5625 -0.0625 0.187494" />
                            <Vertex pos="-2.5625 -0.0625 -0.312494" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -1.76777" album="" material="bm_wood" texgens="0 1 0 -16752 0 0 -1 -4176 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -2.5625" album="" material="bm_wood" texgens="0 -1 0 16752 0 0 -1 -4176 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 26096 0 0 -1 -4176 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 -26096 0 0 -1 -4176 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707112 0.707101 -0.176772" album="" material="bm_wood" texgens="1 0 0 -26096 0 -1 0 16752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.707203 -0.707011 -0.176736" album="" material="bm_wood" texgens="-1 0 0 26096 0 -1 0 16752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="301" owner="0" type="0" pos="-102.5 -66.5625 16.3125" rot="1 0 0 0" scale="" transform="1 0 0 -102.5 0 1 0 -66.5625 0 0 1 16.3125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.0625 0.187504" />
                            <Vertex pos="2 0.0625 -0.3125" />
                            <Vertex pos="1.875 -0.0625 0.312502" />
                            <Vertex pos="1.875 -0.0625 -0.187498" />
                            <Vertex pos="-2 0.0625 0.187504" />
                            <Vertex pos="-2 0.0625 -0.3125" />
                            <Vertex pos="-2 -0.0625 0.312502" />
                            <Vertex pos="-2 -0.0625 -0.187498" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -1.37002" album="" material="bm_wood" texgens="0 1 0 -17040 0 0 -1 -4176 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_wood" texgens="0 -1 0 17040 0 0 -1 -4176 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.0625" album="" material="bm_wood" texgens="-1 0 0 26240 0 0 -1 -4176 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.0625" album="" material="bm_wood" texgens="1 0 0 -26240 0 0 -1 -4176 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707101 0.707112 -0.17678" album="" material="bm_wood" texgens="1 0 0 -26240 0 -1 0 17040 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.707112 -0.707101 -0.176775" album="" material="bm_wood" texgens="-1 0 0 26240 0 -1 0 17040 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="302" owner="0" type="0" pos="-118.75 -64.75 16.25" rot="1 0 0 0" scale="" transform="1 0 0 -118.75 0 1 0 -64.75 0 0 1 16.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 0.25" />
                            <Vertex pos="0.25 0.25 -0.25" />
                            <Vertex pos="0.25 -0.25 0.25" />
                            <Vertex pos="0.25 -0.25 -0.25" />
                            <Vertex pos="-0.25 0.25 0.25" />
                            <Vertex pos="-0.25 0.25 -0.25" />
                            <Vertex pos="-0.25 -0.25 0.25" />
                            <Vertex pos="-0.25 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -960 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1088 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1088 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -960 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="303" owner="0" type="0" pos="-119.25 -66 16.25" rot="1 0 0 0" scale="" transform="1 0 0 -119.25 0 1 0 -66 0 0 1 16.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1.5 0.25" />
                            <Vertex pos="0.25 1.5 -0.25" />
                            <Vertex pos="0.25 -1.5 0.25" />
                            <Vertex pos="0.25 -1.5 -0.25" />
                            <Vertex pos="-0.25 1.5 0.25" />
                            <Vertex pos="-0.25 1.5 -0.25" />
                            <Vertex pos="-0.25 -1.5 0.25" />
                            <Vertex pos="-0.25 -1.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -2560 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 2688 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1.5" album="" material="bm_edge_white" texgens="-1 0 0 -960 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.5" album="" material="bm_edge_white" texgens="1 0 0 1088 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1088 0 -1 0 2688 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -960 0 -1 0 2688 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="304" owner="0" type="0" pos="-115.25 -64.75 16.25" rot="1 0 0 0" scale="" transform="1 0 0 -115.25 0 1 0 -64.75 0 0 1 16.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.25 0.25 0.25" />
                            <Vertex pos="2.25 0.25 -0.25" />
                            <Vertex pos="2.25 -0.25 0.25" />
                            <Vertex pos="2.25 -0.25 -0.25" />
                            <Vertex pos="-2.25 0.25 0.25" />
                            <Vertex pos="-2.25 0.25 -0.25" />
                            <Vertex pos="-2.25 -0.25 0.25" />
                            <Vertex pos="-2.25 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2.25" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.25" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -1472 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1600 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1600 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -1472 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="305" owner="0" type="0" pos="-116 -67.25 16.25" rot="1 0 0 0" scale="" transform="1 0 0 -116 0 1 0 -67.25 0 0 1 16.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.25 0.25" />
                            <Vertex pos="3 0.25 -0.25" />
                            <Vertex pos="3 -0.25 0.25" />
                            <Vertex pos="3 -0.25 -0.25" />
                            <Vertex pos="-3 0.25 0.25" />
                            <Vertex pos="-3 0.25 -0.25" />
                            <Vertex pos="-3 -0.25 0.25" />
                            <Vertex pos="-3 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -1280 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1408 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -1280 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="306" owner="0" type="0" pos="-101.25 -74.25 16.25" rot="1 0 0 0" scale="" transform="1 0 0 -101.25 0 1 0 -74.25 0 0 1 16.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3.25 0.25" />
                            <Vertex pos="0.25 3.25 -0.25" />
                            <Vertex pos="0.25 -3.25 0.25" />
                            <Vertex pos="0.25 -3.25 -0.25" />
                            <Vertex pos="-0.25 3.25 0.25" />
                            <Vertex pos="-0.25 3.25 -0.25" />
                            <Vertex pos="-0.25 -3.25 0.25" />
                            <Vertex pos="-0.25 -3.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -2112 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 2240 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3.25" album="" material="bm_edge_white" texgens="-1 0 0 -960 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3.25" album="" material="bm_edge_white" texgens="1 0 0 1088 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1088 0 -1 0 2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -960 0 -1 0 2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="307" owner="0" type="0" pos="-95 -77.25 16.25" rot="1 0 0 0" scale="" transform="1 0 0 -95 0 1 0 -77.25 0 0 1 16.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.25 0.25" />
                            <Vertex pos="6 0.25 -0.25" />
                            <Vertex pos="6 -0.25 0.25" />
                            <Vertex pos="6 -0.25 -0.25" />
                            <Vertex pos="-6 0.25 0.25" />
                            <Vertex pos="-6 0.25 -0.25" />
                            <Vertex pos="-6 -0.25 0.25" />
                            <Vertex pos="-6 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -2048 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 2176 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 2176 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -2048 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="308" owner="0" type="0" pos="-105.25 -74.25 26.25" rot="1 0 0 0" scale="" transform="1 0 0 -105.25 0 1 0 -74.25 0 0 1 26.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3.25 0.25" />
                            <Vertex pos="0.25 3.25 -0.25" />
                            <Vertex pos="0.25 -3.25 0.25" />
                            <Vertex pos="0.25 -3.25 -0.25" />
                            <Vertex pos="-0.25 3.25 0.25" />
                            <Vertex pos="-0.25 3.25 -0.25" />
                            <Vertex pos="-0.25 -3.25 0.25" />
                            <Vertex pos="-0.25 -3.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -2112 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 2240 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3.25" album="" material="bm_edge_white" texgens="-1 0 0 -960 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3.25" album="" material="bm_edge_white" texgens="1 0 0 1088 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1088 0 -1 0 2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -960 0 -1 0 2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="309" owner="0" type="0" pos="-99 -77.25 26.25" rot="1 0 0 0" scale="" transform="1 0 0 -99 0 1 0 -77.25 0 0 1 26.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.25 0.25" />
                            <Vertex pos="6 0.25 -0.25" />
                            <Vertex pos="6 -0.25 0.25" />
                            <Vertex pos="6 -0.25 -0.25" />
                            <Vertex pos="-6 0.25 0.25" />
                            <Vertex pos="-6 0.25 -0.25" />
                            <Vertex pos="-6 -0.25 0.25" />
                            <Vertex pos="-6 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -2048 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 2176 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 2176 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -2048 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="310" owner="0" type="0" pos="-105.25 -45 26.25" rot="1 0 0 0" scale="" transform="1 0 0 -105.25 0 1 0 -45 0 0 1 26.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 6 0.25" />
                            <Vertex pos="0.25 6 -0.25" />
                            <Vertex pos="0.25 -6 0.25" />
                            <Vertex pos="0.25 -6 -0.25" />
                            <Vertex pos="-0.25 6 0.25" />
                            <Vertex pos="-0.25 6 -0.25" />
                            <Vertex pos="-0.25 -6 0.25" />
                            <Vertex pos="-0.25 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 -960 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 1088 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1088 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -960 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="311" owner="0" type="0" pos="-98.75 -45 26.25" rot="1 0 0 0" scale="" transform="1 0 0 -98.75 0 1 0 -45 0 0 1 26.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 6 0.25" />
                            <Vertex pos="0.25 6 -0.25" />
                            <Vertex pos="0.25 -6 0.25" />
                            <Vertex pos="0.25 -6 -0.25" />
                            <Vertex pos="-0.25 6 0.25" />
                            <Vertex pos="-0.25 6 -0.25" />
                            <Vertex pos="-0.25 -6 0.25" />
                            <Vertex pos="-0.25 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 -960 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 1088 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1088 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -960 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="312" owner="0" type="0" pos="-105.25 12 36.25" rot="1 0 0 0" scale="" transform="1 0 0 -105.25 0 1 0 12 0 0 1 36.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3 0.25" />
                            <Vertex pos="0.25 3 -0.25" />
                            <Vertex pos="0.25 -3 0.25" />
                            <Vertex pos="0.25 -3 -0.25" />
                            <Vertex pos="-0.25 3 0.25" />
                            <Vertex pos="-0.25 3 -0.25" />
                            <Vertex pos="-0.25 -3 0.25" />
                            <Vertex pos="-0.25 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="313" owner="0" type="0" pos="-98.75 12 36.25" rot="1 0 0 0" scale="" transform="1 0 0 -98.75 0 1 0 12 0 0 1 36.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3 0.25" />
                            <Vertex pos="0.25 3 -0.25" />
                            <Vertex pos="0.25 -3 0.25" />
                            <Vertex pos="0.25 -3 -0.25" />
                            <Vertex pos="-0.25 3 0.25" />
                            <Vertex pos="-0.25 3 -0.25" />
                            <Vertex pos="-0.25 -3 0.25" />
                            <Vertex pos="-0.25 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="314" owner="0" type="0" pos="-102 15.25 36.25" rot="1 0 0 0" scale="" transform="1 0 0 -102 0 1 0 15.25 0 0 1 36.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.5 0.25 0.25" />
                            <Vertex pos="3.5 0.25 -0.25" />
                            <Vertex pos="3.5 -0.25 0.25" />
                            <Vertex pos="3.5 -0.25 -0.25" />
                            <Vertex pos="-3.5 0.25 0.25" />
                            <Vertex pos="-3.5 0.25 -0.25" />
                            <Vertex pos="-3.5 -0.25 0.25" />
                            <Vertex pos="-3.5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3.5" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3.5" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -768 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 896 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="315" owner="6" type="999" pos="-110 -70 17.5" rot="1 0 0 0" scale="" transform="1 0 0 -110 0 1 0 -70 0 0 1 17.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 1" />
                            <Vertex pos="1 1 -1" />
                            <Vertex pos="1 -1 1" />
                            <Vertex pos="1 -1 -1" />
                            <Vertex pos="-1 1 1" />
                            <Vertex pos="-1 1 -1" />
                            <Vertex pos="-1 -1 1" />
                            <Vertex pos="-1 -1 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_basher" texgens="0 1 0 256 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_basher" texgens="0 -1 0 256 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_basher_side" texgens="-1 0 0 256 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_basher_side" texgens="1 0 0 256 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_basher_top" texgens="1 0 0 256 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_basher_top" texgens="-1 0 0 256 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="316" owner="0" type="0" pos="-97 -61 -13.5" rot="1 0 0 0" scale="" transform="1 0 0 -97 0 1 0 -61 0 0 1 -13.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8 8 8" />
                            <Vertex pos="8 8 -10" />
                            <Vertex pos="8 -8 8" />
                            <Vertex pos="8 -8 -10" />
                            <Vertex pos="-8 8 8" />
                            <Vertex pos="-8 8 -10" />
                            <Vertex pos="-8 -8 8" />
                            <Vertex pos="-8 -8 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -8" album="" material="bm_grid_blank4" texgens="0 1 0 -2560 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -8" album="" material="bm_grid_blank4" texgens="0 -1 0 2304 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -8" album="" material="bm_grid_blank_water" texgens="1 0 0 1024 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 -1 0 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="319" owner="0" type="0" pos="-18 -20 -17.5" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 -20 0 0 1 -17.5 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="17">
                        <Vertices>
                            <Vertex pos="2.12132 2.12125 -6" />
                            <Vertex pos="2.12132 2.12125 6" />
                            <Vertex pos="3 3.8147e-006 -6" />
                            <Vertex pos="3 3.8147e-006 6" />
                            <Vertex pos="-9.05991e-006 3 -6" />
                            <Vertex pos="-9.05991e-006 3 6" />
                            <Vertex pos="-2.12132 2.12125 -6" />
                            <Vertex pos="-2.12132 2.12125 6" />
                            <Vertex pos="-3 7.62939e-006 -6" />
                            <Vertex pos="-3 7.62939e-006 6" />
                            <Vertex pos="-2.12131 -2.12125 -6" />
                            <Vertex pos="-2.12131 -2.12125 6" />
                            <Vertex pos="4.76837e-006 -3 -6" />
                            <Vertex pos="4.76837e-006 -3 6" />
                            <Vertex pos="2.12134 -2.12126 -6" />
                            <Vertex pos="2.12134 -2.12126 6" />
                        </Vertices>
                        <Face id="0" plane="0.923875 0.382695 0 -2.77163" album="" material="bm_grid_blank4" texgens="-0.382684 0.92388 0 127.988 0 0 -1 768 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.382708 0.923869 -0 -2.7716" album="" material="bm_grid_blank4" texgens="-0.92388 0.382682 0 128.003 0 0 -1 768 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="-0.382711 0.923868 0 -2.77161" album="" material="bm_grid_blank4" texgens="-0.92388 -0.382683 0 128.006 0 0 -1 768 0 0.28701 0.25" texRot="0" texScale="0.28701 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="-0.923874 0.382696 0 -2.77163" album="" material="bm_grid_blank4" texgens="-0.382687 -0.923878 0 128.014 0 0 -1 768 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="-0.923874 -0.382697 0 -2.77162" album="" material="bm_grid_blank4" texgens="0.382682 -0.92388 0 127.979 0 0 -1 768 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="-0.382711 -0.923868 0 -2.7716" album="" material="bm_grid_blank4" texgens="0.92388 -0.382683 0 128.003 0 0 -1 768 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="0.382704 -0.923871 0 -2.77162" album="" material="bm_grid_blank4" texgens="0.923878 0.382686 0 127.998 0 0 -1 768 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="0.923879 -0.382685 0 -2.77164" album="" material="bm_grid_blank4" texgens="0.382681 0.92388 0 128.025 0 0 -1 768 0 0.287011 0.25" texRot="0" texScale="0.287011 0.25" texDiv="256 256">
                            <Indices indices=" 15 3 2 14" />
                        </Face>
                        <Face id="8" plane="-0 0 -1 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 14 2 0 4 6 8 10 12" />
                        </Face>
                        <Face id="9" plane="0 -0 1 -6" album="" material="bm_friction_grass" texgens="1 0 0 -2304 0 -1 0 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="320" owner="0" type="0" pos="-18 -20 -0.5" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 -20 0 0 1 -0.5 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="33">
                        <Vertices>
                            <Vertex pos="0.692907 0.286877 -11" />
                            <Vertex pos="0.692907 0.286877 19" />
                            <Vertex pos="0.75 0 -11" />
                            <Vertex pos="0.75 0 19" />
                            <Vertex pos="0.530345 0.530308 -11" />
                            <Vertex pos="0.530345 0.530308 19" />
                            <Vertex pos="0.286971 0.69281 -11" />
                            <Vertex pos="0.286971 0.69281 19" />
                            <Vertex pos="2.47955e-005 0.75 -11" />
                            <Vertex pos="2.47955e-005 0.75 19" />
                            <Vertex pos="-0.287071 0.692814 -11" />
                            <Vertex pos="-0.287071 0.692814 19" />
                            <Vertex pos="-0.530313 0.530315 -11" />
                            <Vertex pos="-0.530313 0.530315 19" />
                            <Vertex pos="-0.692904 0.286884 -11" />
                            <Vertex pos="-0.692904 0.286884 19" />
                            <Vertex pos="-0.75 0 -11" />
                            <Vertex pos="-0.75 0 19" />
                            <Vertex pos="-0.692907 -0.286873 -11" />
                            <Vertex pos="-0.692907 -0.286873 19" />
                            <Vertex pos="-0.530376 -0.530308 -11" />
                            <Vertex pos="-0.530376 -0.530308 19" />
                            <Vertex pos="-0.286956 -0.692818 -11" />
                            <Vertex pos="-0.286956 -0.692818 19" />
                            <Vertex pos="1.00136e-005 -0.750004 -11" />
                            <Vertex pos="9.53674e-006 -0.750004 19" />
                            <Vertex pos="0.286997 -0.692822 -11" />
                            <Vertex pos="0.286997 -0.692822 19" />
                            <Vertex pos="0.53034 -0.530319 -11" />
                            <Vertex pos="0.53034 -0.530319 19" />
                            <Vertex pos="0.692906 -0.28688 -11" />
                            <Vertex pos="0.692905 -0.28688 19" />
                        </Vertices>
                        <Face id="0" plane="0.980766 0.195188 0 -0.735574" album="" material="solid_bm" texgens="-0.195089 0.980786 0 4.6792 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.831617 0.55535 -0 -0.73555" album="" material="solid_bm" texgens="-0.555572 0.831468 0 14.0393 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0.555298 0.831652 -0 -0.735531" album="" material="solid_bm" texgens="-0.831471 0.555569 0 23.4103 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="0.195461 0.980711 -0 -0.735538" album="" material="solid_bm" texgens="-0.980786 0.195088 0 32.7745 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="-0.19535 0.980734 0 -0.735545" album="" material="solid_bm" texgens="-0.980784 -0.195095 0 42.1397 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="-0.555499 0.831517 0 -0.735554" album="" material="solid_bm" texgens="-0.831471 -0.555568 0 51.5062 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="-0.831571 0.555418 0 -0.73554" album="" material="solid_bm" texgens="-0.555573 -0.831468 0 60.8636 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="-0.980765 0.195193 0 -0.735574" album="" material="solid_bm" texgens="-0.195092 -0.980785 0 70.2384 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 17 16 14 15" />
                        </Face>
                        <Face id="8" plane="-0.980765 -0.19519 0 -0.735574" album="" material="solid_bm" texgens="0.195089 -0.980786 0 79.6007 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 19 18 16 17" />
                        </Face>
                        <Face id="9" plane="-0.83167 -0.55527 0 -0.735562" album="" material="solid_bm" texgens="0.555567 -0.831472 0 88.9565 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 21 20 18 19" />
                        </Face>
                        <Face id="10" plane="-0.555244 -0.831687 0 -0.735539" album="" material="solid_bm" texgens="0.831471 -0.555569 0 98.3286 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 23 22 20 21" />
                        </Face>
                        <Face id="11" plane="-0.195435 -0.980717 -3.10651e-009 -0.735539" album="" material="solid_bm" texgens="0.980786 -0.195089 0 107.69 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 25 24 22 23" />
                        </Face>
                        <Face id="12" plane="0.195408 -0.980722 0 -0.735547" album="" material="solid_bm" texgens="0.980785 0.195092 0 117.055 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 27 26 24 25" />
                        </Face>
                        <Face id="13" plane="0.555349 -0.831617 0 -0.735546" album="" material="solid_bm" texgens="0.831468 0.555572 0 126.421 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 29 28 26 27" />
                        </Face>
                        <Face id="14" plane="0.831619 -0.555346 2.80887e-008 -0.735551" album="" material="solid_bm" texgens="0.555569 0.83147 0 135.786 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 30 28 29" />
                        </Face>
                        <Face id="15" plane="0.980765 -0.195192 0 -0.735574" album="" material="solid_bm" texgens="0.195087 0.980786 0 145.144 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 3 2 30" />
                        </Face>
                        <Face id="16" plane="-0 0 -1 -11" album="" material="solid_bm" texgens="-1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 30 2 0 4 6 8 10 12 14 16 18 20 22 24 26 28" />
                        </Face>
                        <Face id="17" plane="0 -0 1 -19" album="" material="solid_bm" texgens="1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 29 27 25 23 21 19 17 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="321" owner="0" type="0" pos="20 -78 -17.5" rot="1 0 0 0" scale="" transform="1 0 0 20 0 1 0 -78 0 0 1 -17.5 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="17">
                        <Vertices>
                            <Vertex pos="2.12132 2.12125 -6" />
                            <Vertex pos="2.12132 2.12125 6" />
                            <Vertex pos="3 3.8147e-006 -6" />
                            <Vertex pos="3 3.8147e-006 6" />
                            <Vertex pos="-9.05991e-006 3 -6" />
                            <Vertex pos="-9.05991e-006 3 6" />
                            <Vertex pos="-2.12132 2.12125 -6" />
                            <Vertex pos="-2.12132 2.12125 6" />
                            <Vertex pos="-3 7.62939e-006 -6" />
                            <Vertex pos="-3 7.62939e-006 6" />
                            <Vertex pos="-2.12131 -2.12125 -6" />
                            <Vertex pos="-2.12131 -2.12125 6" />
                            <Vertex pos="4.76837e-006 -3 -6" />
                            <Vertex pos="4.76837e-006 -3 6" />
                            <Vertex pos="2.12134 -2.12126 -6" />
                            <Vertex pos="2.12134 -2.12126 6" />
                        </Vertices>
                        <Face id="0" plane="0.923875 0.382695 0 -2.77163" album="" material="bm_grid_blank4" texgens="-0.382684 0.92388 0 127.988 0 0 -1 768 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.382708 0.923869 -0 -2.7716" album="" material="bm_grid_blank4" texgens="-0.92388 0.382682 0 128.003 0 0 -1 768 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="-0.382711 0.923868 0 -2.77161" album="" material="bm_grid_blank4" texgens="-0.92388 -0.382683 0 128.006 0 0 -1 768 0 0.28701 0.25" texRot="0" texScale="0.28701 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="-0.923874 0.382696 0 -2.77163" album="" material="bm_grid_blank4" texgens="-0.382687 -0.923878 0 128.014 0 0 -1 768 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="-0.923874 -0.382697 0 -2.77162" album="" material="bm_grid_blank4" texgens="0.382682 -0.92388 0 127.979 0 0 -1 768 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="-0.382711 -0.923868 0 -2.7716" album="" material="bm_grid_blank4" texgens="0.92388 -0.382683 0 128.003 0 0 -1 768 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="0.382704 -0.923871 0 -2.77162" album="" material="bm_grid_blank4" texgens="0.923878 0.382686 0 127.998 0 0 -1 768 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="0.923879 -0.382685 0 -2.77164" album="" material="bm_grid_blank4" texgens="0.382681 0.92388 0 128.025 0 0 -1 768 0 0.287011 0.25" texRot="0" texScale="0.287011 0.25" texDiv="256 256">
                            <Indices indices=" 15 3 2 14" />
                        </Face>
                        <Face id="8" plane="-0 0 -1 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 14 2 0 4 6 8 10 12" />
                        </Face>
                        <Face id="9" plane="0 -0 1 -6" album="" material="bm_friction_grass" texgens="1 0 0 2560 0 -1 0 9984 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="322" owner="0" type="0" pos="20 -78 -0.5" rot="1 0 0 0" scale="" transform="1 0 0 20 0 1 0 -78 0 0 1 -0.5 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="33">
                        <Vertices>
                            <Vertex pos="0.692907 0.286877 -11" />
                            <Vertex pos="0.692907 0.28688 23" />
                            <Vertex pos="0.75 0 -11" />
                            <Vertex pos="0.75 0 23" />
                            <Vertex pos="0.530345 0.530308 -11" />
                            <Vertex pos="0.530346 0.530304 23" />
                            <Vertex pos="0.286971 0.69281 -11" />
                            <Vertex pos="0.286972 0.69281 23" />
                            <Vertex pos="2.47955e-005 0.75 -11" />
                            <Vertex pos="2.47955e-005 0.75 23" />
                            <Vertex pos="-0.287071 0.692814 -11" />
                            <Vertex pos="-0.287071 0.69281 23" />
                            <Vertex pos="-0.530313 0.530315 -11" />
                            <Vertex pos="-0.530312 0.530319 23" />
                            <Vertex pos="-0.692904 0.286884 -11" />
                            <Vertex pos="-0.692905 0.28688 23" />
                            <Vertex pos="-0.75 0 -11" />
                            <Vertex pos="-0.75 0 23" />
                            <Vertex pos="-0.692907 -0.286873 -11" />
                            <Vertex pos="-0.692907 -0.286873 23" />
                            <Vertex pos="-0.530376 -0.530308 -11" />
                            <Vertex pos="-0.530376 -0.530304 23" />
                            <Vertex pos="-0.286956 -0.692818 -11" />
                            <Vertex pos="-0.286957 -0.692818 23" />
                            <Vertex pos="1.00136e-005 -0.750004 -11" />
                            <Vertex pos="9.53674e-006 -0.75 23" />
                            <Vertex pos="0.286997 -0.692822 -11" />
                            <Vertex pos="0.286997 -0.692825 23" />
                            <Vertex pos="0.53034 -0.530319 -11" />
                            <Vertex pos="0.53034 -0.530319 23" />
                            <Vertex pos="0.692906 -0.28688 -11" />
                            <Vertex pos="0.692905 -0.28688 23" />
                        </Vertices>
                        <Face id="0" plane="0.980766 0.195186 -1.71088e-008 -0.735574" album="" material="solid_bm" texgens="-0.195089 0.980786 0 4.6792 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.831617 0.55535 4.1903e-008 -0.73555" album="" material="solid_bm" texgens="-0.555572 0.831468 0 14.0393 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0.555298 0.831652 -1.60624e-008 -0.735531" album="" material="solid_bm" texgens="-0.831471 0.555569 0 23.4103 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="0.195461 0.980711 -0 -0.735538" album="" material="solid_bm" texgens="-0.980786 0.195088 0 32.7745 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="-0.19535 0.980734 1.15193e-007 -0.735544" album="" material="solid_bm" texgens="-0.980784 -0.195095 0 42.1397 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="-0.555499 0.831517 -8.11117e-008 -0.735555" album="" material="solid_bm" texgens="-0.831471 -0.555568 0 51.5062 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="-0.831571 0.555418 4.09414e-008 -0.735539" album="" material="solid_bm" texgens="-0.555573 -0.831468 0 60.8636 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="-0.980765 0.195193 0 -0.735574" album="" material="solid_bm" texgens="-0.195092 -0.980785 0 70.2384 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 17 16 14 15" />
                        </Face>
                        <Face id="8" plane="-0.980765 -0.19519 0 -0.735574" album="" material="solid_bm" texgens="0.195089 -0.980786 0 79.6007 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 19 18 16 17" />
                        </Face>
                        <Face id="9" plane="-0.83167 -0.55527 6.52199e-008 -0.735561" album="" material="solid_bm" texgens="0.555567 -0.831472 0 88.9565 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 21 20 18 19" />
                        </Face>
                        <Face id="10" plane="-0.555244 -0.831688 -1.60609e-008 -0.735539" album="" material="solid_bm" texgens="0.831471 -0.555569 0 98.3286 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 23 22 20 21" />
                        </Face>
                        <Face id="11" plane="-0.195435 -0.980717 1.1245e-007 -0.735538" album="" material="solid_bm" texgens="0.980786 -0.195089 0 107.69 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 25 24 22 23" />
                        </Face>
                        <Face id="12" plane="0.195408 -0.980722 -8.76834e-008 -0.735548" album="" material="solid_bm" texgens="0.980785 0.195092 0 117.055 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 27 26 24 25" />
                        </Face>
                        <Face id="13" plane="0.555349 -0.831617 0 -0.735546" album="" material="solid_bm" texgens="0.831468 0.555572 0 126.421 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 29 28 26 27" />
                        </Face>
                        <Face id="14" plane="0.831619 -0.555346 2.47842e-008 -0.735551" album="" material="solid_bm" texgens="0.555569 0.83147 0 135.786 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 30 28 29" />
                        </Face>
                        <Face id="15" plane="0.980765 -0.195192 0 -0.735574" album="" material="solid_bm" texgens="0.195087 0.980786 0 145.144 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 3 2 30" />
                        </Face>
                        <Face id="16" plane="-0 0 -1 -11" album="" material="solid_bm" texgens="-1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 30 2 0 4 6 8 10 12 14 16 18 20 22 24 26 28" />
                        </Face>
                        <Face id="17" plane="0 -0 1 -23" album="" material="solid_bm" texgens="1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 29 27 25 23 21 19 17 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="323" owner="0" type="0" pos="-42 -78 -17.5" rot="1 0 0 0" scale="" transform="1 0 0 -42 0 1 0 -78 0 0 1 -17.5 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="17">
                        <Vertices>
                            <Vertex pos="2.12132 2.12125 -6" />
                            <Vertex pos="2.12132 2.12125 6" />
                            <Vertex pos="3 3.8147e-006 -6" />
                            <Vertex pos="3 3.8147e-006 6" />
                            <Vertex pos="-9.05991e-006 3 -6" />
                            <Vertex pos="-9.05991e-006 3 6" />
                            <Vertex pos="-2.12132 2.12125 -6" />
                            <Vertex pos="-2.12132 2.12125 6" />
                            <Vertex pos="-3 7.62939e-006 -6" />
                            <Vertex pos="-3 7.62939e-006 6" />
                            <Vertex pos="-2.12131 -2.12125 -6" />
                            <Vertex pos="-2.12131 -2.12125 6" />
                            <Vertex pos="4.76837e-006 -3 -6" />
                            <Vertex pos="4.76837e-006 -3 6" />
                            <Vertex pos="2.12134 -2.12126 -6" />
                            <Vertex pos="2.12134 -2.12126 6" />
                        </Vertices>
                        <Face id="0" plane="0.923875 0.382695 0 -2.77163" album="" material="bm_grid_blank4" texgens="-0.382684 0.92388 0 127.988 0 0 -1 768 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.382708 0.923869 -0 -2.7716" album="" material="bm_grid_blank4" texgens="-0.92388 0.382682 0 128.003 0 0 -1 768 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="-0.382711 0.923868 0 -2.77161" album="" material="bm_grid_blank4" texgens="-0.92388 -0.382683 0 128.006 0 0 -1 768 0 0.28701 0.25" texRot="0" texScale="0.28701 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="-0.923874 0.382696 0 -2.77163" album="" material="bm_grid_blank4" texgens="-0.382687 -0.923878 0 128.014 0 0 -1 768 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="-0.923874 -0.382697 0 -2.77162" album="" material="bm_grid_blank4" texgens="0.382682 -0.92388 0 127.979 0 0 -1 768 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="-0.382711 -0.923868 0 -2.7716" album="" material="bm_grid_blank4" texgens="0.92388 -0.382683 0 128.003 0 0 -1 768 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="0.382704 -0.923871 0 -2.77162" album="" material="bm_grid_blank4" texgens="0.923878 0.382686 0 127.998 0 0 -1 768 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="0.923879 -0.382685 0 -2.77164" album="" material="bm_grid_blank4" texgens="0.382681 0.92388 0 128.025 0 0 -1 768 0 0.287011 0.25" texRot="0" texScale="0.287011 0.25" texDiv="256 256">
                            <Indices indices=" 15 3 2 14" />
                        </Face>
                        <Face id="8" plane="-0 0 -1 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 14 2 0 4 6 8 10 12" />
                        </Face>
                        <Face id="9" plane="0 -0 1 -6" album="" material="bm_friction_grass" texgens="1 0 0 -5376 0 -1 0 9984 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="324" owner="0" type="0" pos="-42 -78 -0.5" rot="1 0 0 0" scale="" transform="1 0 0 -42 0 1 0 -78 0 0 1 -0.5 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="33">
                        <Vertices>
                            <Vertex pos="0.692907 0.286877 -11" />
                            <Vertex pos="0.692909 0.28688 31" />
                            <Vertex pos="0.75 0 -11" />
                            <Vertex pos="0.75 0 31" />
                            <Vertex pos="0.530345 0.530308 -11" />
                            <Vertex pos="0.530346 0.530304 31" />
                            <Vertex pos="0.286971 0.69281 -11" />
                            <Vertex pos="0.286972 0.69281 31" />
                            <Vertex pos="2.47955e-005 0.75 -11" />
                            <Vertex pos="2.28882e-005 0.75 31" />
                            <Vertex pos="-0.287071 0.692814 -11" />
                            <Vertex pos="-0.287071 0.69281 31" />
                            <Vertex pos="-0.530313 0.530315 -11" />
                            <Vertex pos="-0.530312 0.530319 31" />
                            <Vertex pos="-0.692904 0.286884 -11" />
                            <Vertex pos="-0.692905 0.28688 31" />
                            <Vertex pos="-0.75 0 -11" />
                            <Vertex pos="-0.75 0 31" />
                            <Vertex pos="-0.692907 -0.286873 -11" />
                            <Vertex pos="-0.692909 -0.286873 31" />
                            <Vertex pos="-0.530376 -0.530308 -11" />
                            <Vertex pos="-0.530376 -0.530304 31" />
                            <Vertex pos="-0.286956 -0.692818 -11" />
                            <Vertex pos="-0.286957 -0.692818 31" />
                            <Vertex pos="1.00136e-005 -0.750004 -11" />
                            <Vertex pos="7.62939e-006 -0.75 31" />
                            <Vertex pos="0.286997 -0.692822 -11" />
                            <Vertex pos="0.286995 -0.692825 31" />
                            <Vertex pos="0.53034 -0.530319 -11" />
                            <Vertex pos="0.530342 -0.530319 31" />
                            <Vertex pos="0.692906 -0.28688 -11" />
                            <Vertex pos="0.692905 -0.28688 31" />
                        </Vertices>
                        <Face id="0" plane="0.980768 0.195179 -6.11729e-008 -0.735574" album="" material="solid_bm" texgens="-0.195089 0.980786 0 4.6792 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.831617 0.55535 3.39215e-008 -0.73555" album="" material="solid_bm" texgens="-0.555572 0.831468 0 14.0393 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0.555298 0.831652 -1.30029e-008 -0.735531" album="" material="solid_bm" texgens="-0.831471 0.555569 0 23.4103 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="0.195461 0.980711 8.87627e-009 -0.735538" album="" material="solid_bm" texgens="-0.980786 0.195088 0 32.7745 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="-0.19535 0.980734 9.32517e-008 -0.735544" album="" material="solid_bm" texgens="-0.980784 -0.195095 0 42.1397 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="-0.555499 0.831517 -6.56618e-008 -0.735555" album="" material="solid_bm" texgens="-0.831471 -0.555568 0 51.5062 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="-0.831571 0.555418 3.3143e-008 -0.735539" album="" material="solid_bm" texgens="-0.555573 -0.831468 0 60.8636 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="-0.980765 0.195193 0 -0.735574" album="" material="solid_bm" texgens="-0.195092 -0.980785 0 70.2384 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 17 16 14 15" />
                        </Face>
                        <Face id="8" plane="-0.980765 -0.19519 -4.73233e-008 -0.735575" album="" material="solid_bm" texgens="0.195089 -0.980786 0 79.6007 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 19 18 16 17" />
                        </Face>
                        <Face id="9" plane="-0.83167 -0.55527 5.27971e-008 -0.735561" album="" material="solid_bm" texgens="0.555567 -0.831472 0 88.9565 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 21 20 18 19" />
                        </Face>
                        <Face id="10" plane="-0.555244 -0.831687 -1.30017e-008 -0.735539" album="" material="solid_bm" texgens="0.831471 -0.555569 0 98.3286 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 23 22 20 21" />
                        </Face>
                        <Face id="11" plane="-0.195435 -0.980717 8.21558e-008 -0.735538" album="" material="solid_bm" texgens="0.980786 -0.195089 0 107.69 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 25 24 22 23" />
                        </Face>
                        <Face id="12" plane="0.195408 -0.980722 -6.16917e-008 -0.735548" album="" material="solid_bm" texgens="0.980785 0.195092 0 117.055 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 27 26 24 25" />
                        </Face>
                        <Face id="13" plane="0.555349 -0.831617 -2.60082e-008 -0.735547" album="" material="solid_bm" texgens="0.831468 0.555572 0 126.421 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 29 28 26 27" />
                        </Face>
                        <Face id="14" plane="0.831619 -0.555346 2.00634e-008 -0.735551" album="" material="solid_bm" texgens="0.555569 0.83147 0 135.786 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 30 28 29" />
                        </Face>
                        <Face id="15" plane="0.980765 -0.195192 0 -0.735574" album="" material="solid_bm" texgens="0.195087 0.980786 0 145.144 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 3 2 30" />
                        </Face>
                        <Face id="16" plane="-0 0 -1 -11" album="" material="solid_bm" texgens="-1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 30 2 0 4 6 8 10 12 14 16 18 20 22 24 26 28" />
                        </Face>
                        <Face id="17" plane="0 -0 1 -31" album="" material="solid_bm" texgens="1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 29 27 25 23 21 19 17 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="325" owner="0" type="0" pos="-64 -78 -17.5" rot="1 0 0 0" scale="" transform="1 0 0 -64 0 1 0 -78 0 0 1 -17.5 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="17">
                        <Vertices>
                            <Vertex pos="2.12132 2.12125 -6" />
                            <Vertex pos="2.12132 2.12125 6" />
                            <Vertex pos="3 3.8147e-006 -6" />
                            <Vertex pos="3 3.8147e-006 6" />
                            <Vertex pos="-9.05991e-006 3 -6" />
                            <Vertex pos="-9.05991e-006 3 6" />
                            <Vertex pos="-2.12132 2.12125 -6" />
                            <Vertex pos="-2.12132 2.12125 6" />
                            <Vertex pos="-3 7.62939e-006 -6" />
                            <Vertex pos="-3 7.62939e-006 6" />
                            <Vertex pos="-2.12131 -2.12125 -6" />
                            <Vertex pos="-2.12131 -2.12125 6" />
                            <Vertex pos="4.76837e-006 -3 -6" />
                            <Vertex pos="4.76837e-006 -3 6" />
                            <Vertex pos="2.12134 -2.12126 -6" />
                            <Vertex pos="2.12134 -2.12126 6" />
                        </Vertices>
                        <Face id="0" plane="0.923875 0.382695 0 -2.77163" album="" material="bm_grid_blank4" texgens="-0.382684 0.92388 0 127.988 0 0 -1 768 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.382708 0.923869 -0 -2.7716" album="" material="bm_grid_blank4" texgens="-0.92388 0.382682 0 128.003 0 0 -1 768 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="-0.382711 0.923868 0 -2.77161" album="" material="bm_grid_blank4" texgens="-0.92388 -0.382683 0 128.006 0 0 -1 768 0 0.28701 0.25" texRot="0" texScale="0.28701 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="-0.923874 0.382696 0 -2.77163" album="" material="bm_grid_blank4" texgens="-0.382687 -0.923878 0 128.014 0 0 -1 768 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="-0.923874 -0.382697 0 -2.77162" album="" material="bm_grid_blank4" texgens="0.382682 -0.92388 0 127.979 0 0 -1 768 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="-0.382711 -0.923868 0 -2.7716" album="" material="bm_grid_blank4" texgens="0.92388 -0.382683 0 128.003 0 0 -1 768 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="0.382704 -0.923871 0 -2.77162" album="" material="bm_grid_blank4" texgens="0.923878 0.382686 0 127.998 0 0 -1 768 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="0.923879 -0.382685 0 -2.77164" album="" material="bm_grid_blank4" texgens="0.382681 0.92388 0 128.025 0 0 -1 768 0 0.287011 0.25" texRot="0" texScale="0.287011 0.25" texDiv="256 256">
                            <Indices indices=" 15 3 2 14" />
                        </Face>
                        <Face id="8" plane="-0 0 -1 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 14 2 0 4 6 8 10 12" />
                        </Face>
                        <Face id="9" plane="0 -0 1 -6" album="" material="bm_friction_grass" texgens="1 0 0 -8192 0 -1 0 9984 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="326" owner="0" type="0" pos="-64 -78 -0.5" rot="1 0 0 0" scale="" transform="1 0 0 -64 0 1 0 -78 0 0 1 -0.5 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="33">
                        <Vertices>
                            <Vertex pos="0.692907 0.286877 -11" />
                            <Vertex pos="0.692907 0.28688 23" />
                            <Vertex pos="0.75 0 -11" />
                            <Vertex pos="0.75 0 23" />
                            <Vertex pos="0.530345 0.530308 -11" />
                            <Vertex pos="0.530346 0.530304 23" />
                            <Vertex pos="0.286971 0.69281 -11" />
                            <Vertex pos="0.286972 0.69281 23" />
                            <Vertex pos="2.47955e-005 0.75 -11" />
                            <Vertex pos="2.47955e-005 0.75 23" />
                            <Vertex pos="-0.287071 0.692814 -11" />
                            <Vertex pos="-0.287071 0.69281 23" />
                            <Vertex pos="-0.530313 0.530315 -11" />
                            <Vertex pos="-0.530312 0.530319 23" />
                            <Vertex pos="-0.692904 0.286884 -11" />
                            <Vertex pos="-0.692905 0.28688 23" />
                            <Vertex pos="-0.75 0 -11" />
                            <Vertex pos="-0.75 0 23" />
                            <Vertex pos="-0.692907 -0.286873 -11" />
                            <Vertex pos="-0.692907 -0.286873 23" />
                            <Vertex pos="-0.530376 -0.530308 -11" />
                            <Vertex pos="-0.530376 -0.530304 23" />
                            <Vertex pos="-0.286956 -0.692818 -11" />
                            <Vertex pos="-0.286957 -0.692818 23" />
                            <Vertex pos="1.00136e-005 -0.750004 -11" />
                            <Vertex pos="9.53674e-006 -0.75 23" />
                            <Vertex pos="0.286997 -0.692822 -11" />
                            <Vertex pos="0.286997 -0.692825 23" />
                            <Vertex pos="0.53034 -0.530319 -11" />
                            <Vertex pos="0.53034 -0.530319 23" />
                            <Vertex pos="0.692906 -0.28688 -11" />
                            <Vertex pos="0.692905 -0.28688 23" />
                        </Vertices>
                        <Face id="0" plane="0.980766 0.195186 -1.71088e-008 -0.735574" album="" material="solid_bm" texgens="-0.195089 0.980786 0 4.6792 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.831617 0.55535 4.1903e-008 -0.73555" album="" material="solid_bm" texgens="-0.555572 0.831468 0 14.0393 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0.555298 0.831652 -1.60624e-008 -0.735531" album="" material="solid_bm" texgens="-0.831471 0.555569 0 23.4103 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="0.195461 0.980711 -0 -0.735538" album="" material="solid_bm" texgens="-0.980786 0.195088 0 32.7745 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="-0.19535 0.980734 1.15193e-007 -0.735544" album="" material="solid_bm" texgens="-0.980784 -0.195095 0 42.1397 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="-0.555499 0.831517 -8.11117e-008 -0.735555" album="" material="solid_bm" texgens="-0.831471 -0.555568 0 51.5062 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="-0.831571 0.555418 4.09414e-008 -0.735539" album="" material="solid_bm" texgens="-0.555573 -0.831468 0 60.8636 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="-0.980765 0.195193 0 -0.735574" album="" material="solid_bm" texgens="-0.195092 -0.980785 0 70.2384 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 17 16 14 15" />
                        </Face>
                        <Face id="8" plane="-0.980765 -0.19519 0 -0.735574" album="" material="solid_bm" texgens="0.195089 -0.980786 0 79.6007 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 19 18 16 17" />
                        </Face>
                        <Face id="9" plane="-0.83167 -0.55527 6.52199e-008 -0.735561" album="" material="solid_bm" texgens="0.555567 -0.831472 0 88.9565 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 21 20 18 19" />
                        </Face>
                        <Face id="10" plane="-0.555244 -0.831688 -1.60609e-008 -0.735539" album="" material="solid_bm" texgens="0.831471 -0.555569 0 98.3286 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 23 22 20 21" />
                        </Face>
                        <Face id="11" plane="-0.195435 -0.980717 1.1245e-007 -0.735538" album="" material="solid_bm" texgens="0.980786 -0.195089 0 107.69 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 25 24 22 23" />
                        </Face>
                        <Face id="12" plane="0.195408 -0.980722 -8.76834e-008 -0.735548" album="" material="solid_bm" texgens="0.980785 0.195092 0 117.055 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 27 26 24 25" />
                        </Face>
                        <Face id="13" plane="0.555349 -0.831617 0 -0.735546" album="" material="solid_bm" texgens="0.831468 0.555572 0 126.421 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 29 28 26 27" />
                        </Face>
                        <Face id="14" plane="0.831619 -0.555346 2.47842e-008 -0.735551" album="" material="solid_bm" texgens="0.555569 0.83147 0 135.786 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 30 28 29" />
                        </Face>
                        <Face id="15" plane="0.980765 -0.195192 0 -0.735574" album="" material="solid_bm" texgens="0.195087 0.980786 0 145.144 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 3 2 30" />
                        </Face>
                        <Face id="16" plane="-0 0 -1 -11" album="" material="solid_bm" texgens="-1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 30 2 0 4 6 8 10 12 14 16 18 20 22 24 26 28" />
                        </Face>
                        <Face id="17" plane="0 -0 1 -23" album="" material="solid_bm" texgens="1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 29 27 25 23 21 19 17 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="327" owner="0" type="0" pos="-20 -78 -17.5" rot="1 0 0 0" scale="" transform="1 0 0 -20 0 1 0 -78 0 0 1 -17.5 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="17">
                        <Vertices>
                            <Vertex pos="2.12132 2.12125 -6" />
                            <Vertex pos="2.12132 2.12125 6" />
                            <Vertex pos="3 3.8147e-006 -6" />
                            <Vertex pos="3 3.8147e-006 6" />
                            <Vertex pos="-9.05991e-006 3 -6" />
                            <Vertex pos="-9.05991e-006 3 6" />
                            <Vertex pos="-2.12132 2.12125 -6" />
                            <Vertex pos="-2.12132 2.12125 6" />
                            <Vertex pos="-3 7.62939e-006 -6" />
                            <Vertex pos="-3 7.62939e-006 6" />
                            <Vertex pos="-2.12131 -2.12125 -6" />
                            <Vertex pos="-2.12131 -2.12125 6" />
                            <Vertex pos="4.76837e-006 -3 -6" />
                            <Vertex pos="4.76837e-006 -3 6" />
                            <Vertex pos="2.12134 -2.12126 -6" />
                            <Vertex pos="2.12134 -2.12126 6" />
                        </Vertices>
                        <Face id="0" plane="0.923875 0.382695 0 -2.77163" album="" material="bm_grid_blank4" texgens="-0.382684 0.92388 0 127.988 0 0 -1 768 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.382708 0.923869 -0 -2.7716" album="" material="bm_grid_blank4" texgens="-0.92388 0.382682 0 128.003 0 0 -1 768 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="-0.382711 0.923868 0 -2.77161" album="" material="bm_grid_blank4" texgens="-0.92388 -0.382683 0 128.006 0 0 -1 768 0 0.28701 0.25" texRot="0" texScale="0.28701 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="-0.923874 0.382696 0 -2.77163" album="" material="bm_grid_blank4" texgens="-0.382687 -0.923878 0 128.014 0 0 -1 768 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="-0.923874 -0.382697 0 -2.77162" album="" material="bm_grid_blank4" texgens="0.382682 -0.92388 0 127.979 0 0 -1 768 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="-0.382711 -0.923868 0 -2.7716" album="" material="bm_grid_blank4" texgens="0.92388 -0.382683 0 128.003 0 0 -1 768 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="0.382704 -0.923871 0 -2.77162" album="" material="bm_grid_blank4" texgens="0.923878 0.382686 0 127.998 0 0 -1 768 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="0.923879 -0.382685 0 -2.77164" album="" material="bm_grid_blank4" texgens="0.382681 0.92388 0 128.025 0 0 -1 768 0 0.287011 0.25" texRot="0" texScale="0.287011 0.25" texDiv="256 256">
                            <Indices indices=" 15 3 2 14" />
                        </Face>
                        <Face id="8" plane="-0 0 -1 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 14 2 0 4 6 8 10 12" />
                        </Face>
                        <Face id="9" plane="0 -0 1 -6" album="" material="bm_friction_grass" texgens="1 0 0 -2560 0 -1 0 9984 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="328" owner="0" type="0" pos="-20 -78 -0.5" rot="1 0 0 0" scale="" transform="1 0 0 -20 0 1 0 -78 0 0 1 -0.5 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="33">
                        <Vertices>
                            <Vertex pos="0.692907 0.286877 -11" />
                            <Vertex pos="0.692907 0.28688 23" />
                            <Vertex pos="0.75 0 -11" />
                            <Vertex pos="0.75 0 23" />
                            <Vertex pos="0.530345 0.530308 -11" />
                            <Vertex pos="0.530346 0.530304 23" />
                            <Vertex pos="0.286971 0.69281 -11" />
                            <Vertex pos="0.286972 0.69281 23" />
                            <Vertex pos="2.47955e-005 0.75 -11" />
                            <Vertex pos="2.47955e-005 0.75 23" />
                            <Vertex pos="-0.287071 0.692814 -11" />
                            <Vertex pos="-0.287071 0.69281 23" />
                            <Vertex pos="-0.530313 0.530315 -11" />
                            <Vertex pos="-0.530312 0.530319 23" />
                            <Vertex pos="-0.692904 0.286884 -11" />
                            <Vertex pos="-0.692905 0.28688 23" />
                            <Vertex pos="-0.75 0 -11" />
                            <Vertex pos="-0.75 0 23" />
                            <Vertex pos="-0.692907 -0.286873 -11" />
                            <Vertex pos="-0.692907 -0.286873 23" />
                            <Vertex pos="-0.530376 -0.530308 -11" />
                            <Vertex pos="-0.530376 -0.530304 23" />
                            <Vertex pos="-0.286956 -0.692818 -11" />
                            <Vertex pos="-0.286957 -0.692818 23" />
                            <Vertex pos="1.00136e-005 -0.750004 -11" />
                            <Vertex pos="9.53674e-006 -0.75 23" />
                            <Vertex pos="0.286997 -0.692822 -11" />
                            <Vertex pos="0.286997 -0.692825 23" />
                            <Vertex pos="0.53034 -0.530319 -11" />
                            <Vertex pos="0.53034 -0.530319 23" />
                            <Vertex pos="0.692906 -0.28688 -11" />
                            <Vertex pos="0.692905 -0.28688 23" />
                        </Vertices>
                        <Face id="0" plane="0.980766 0.195186 -1.71088e-008 -0.735574" album="" material="solid_bm" texgens="-0.195089 0.980786 0 4.6792 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.831617 0.55535 4.1903e-008 -0.73555" album="" material="solid_bm" texgens="-0.555572 0.831468 0 14.0393 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0.555298 0.831652 -1.60624e-008 -0.735531" album="" material="solid_bm" texgens="-0.831471 0.555569 0 23.4103 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="0.195461 0.980711 -0 -0.735538" album="" material="solid_bm" texgens="-0.980786 0.195088 0 32.7745 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="-0.19535 0.980734 1.15193e-007 -0.735544" album="" material="solid_bm" texgens="-0.980784 -0.195095 0 42.1397 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="-0.555499 0.831517 -8.11117e-008 -0.735555" album="" material="solid_bm" texgens="-0.831471 -0.555568 0 51.5062 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="-0.831571 0.555418 4.09414e-008 -0.735539" album="" material="solid_bm" texgens="-0.555573 -0.831468 0 60.8636 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="-0.980765 0.195193 0 -0.735574" album="" material="solid_bm" texgens="-0.195092 -0.980785 0 70.2384 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 17 16 14 15" />
                        </Face>
                        <Face id="8" plane="-0.980765 -0.19519 0 -0.735574" album="" material="solid_bm" texgens="0.195089 -0.980786 0 79.6007 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 19 18 16 17" />
                        </Face>
                        <Face id="9" plane="-0.83167 -0.55527 6.52199e-008 -0.735561" album="" material="solid_bm" texgens="0.555567 -0.831472 0 88.9565 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 21 20 18 19" />
                        </Face>
                        <Face id="10" plane="-0.555244 -0.831688 -1.60609e-008 -0.735539" album="" material="solid_bm" texgens="0.831471 -0.555569 0 98.3286 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 23 22 20 21" />
                        </Face>
                        <Face id="11" plane="-0.195435 -0.980717 1.1245e-007 -0.735538" album="" material="solid_bm" texgens="0.980786 -0.195089 0 107.69 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 25 24 22 23" />
                        </Face>
                        <Face id="12" plane="0.195408 -0.980722 -8.76834e-008 -0.735548" album="" material="solid_bm" texgens="0.980785 0.195092 0 117.055 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 27 26 24 25" />
                        </Face>
                        <Face id="13" plane="0.555349 -0.831617 0 -0.735546" album="" material="solid_bm" texgens="0.831468 0.555572 0 126.421 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 29 28 26 27" />
                        </Face>
                        <Face id="14" plane="0.831619 -0.555346 2.47842e-008 -0.735551" album="" material="solid_bm" texgens="0.555569 0.83147 0 135.786 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 30 28 29" />
                        </Face>
                        <Face id="15" plane="0.980765 -0.195192 0 -0.735574" album="" material="solid_bm" texgens="0.195087 0.980786 0 145.144 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 3 2 30" />
                        </Face>
                        <Face id="16" plane="-0 0 -1 -11" album="" material="solid_bm" texgens="-1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 30 2 0 4 6 8 10 12 14 16 18 20 22 24 26 28" />
                        </Face>
                        <Face id="17" plane="0 -0 1 -23" album="" material="solid_bm" texgens="1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 29 27 25 23 21 19 17 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="329" owner="0" type="0" pos="-110 -84 -17.5" rot="1 0 0 0" scale="" transform="1 0 0 -110 0 1 0 -84 0 0 1 -17.5 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="17">
                        <Vertices>
                            <Vertex pos="2.12132 2.12125 -6" />
                            <Vertex pos="2.12132 2.12125 6" />
                            <Vertex pos="3 3.8147e-006 -6" />
                            <Vertex pos="3 3.8147e-006 6" />
                            <Vertex pos="-9.05991e-006 3 -6" />
                            <Vertex pos="-9.05991e-006 3 6" />
                            <Vertex pos="-2.12132 2.12125 -6" />
                            <Vertex pos="-2.12132 2.12125 6" />
                            <Vertex pos="-3 7.62939e-006 -6" />
                            <Vertex pos="-3 7.62939e-006 6" />
                            <Vertex pos="-2.12131 -2.12125 -6" />
                            <Vertex pos="-2.12131 -2.12125 6" />
                            <Vertex pos="4.76837e-006 -3 -6" />
                            <Vertex pos="4.76837e-006 -3 6" />
                            <Vertex pos="2.12134 -2.12126 -6" />
                            <Vertex pos="2.12134 -2.12126 6" />
                        </Vertices>
                        <Face id="0" plane="0.923875 0.382695 0 -2.77163" album="" material="bm_grid_blank4" texgens="-0.382684 0.92388 0 127.988 0 0 -1 768 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.382708 0.923869 -0 -2.7716" album="" material="bm_grid_blank4" texgens="-0.92388 0.382682 0 128.003 0 0 -1 768 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="-0.382711 0.923868 0 -2.77161" album="" material="bm_grid_blank4" texgens="-0.92388 -0.382683 0 128.006 0 0 -1 768 0 0.28701 0.25" texRot="0" texScale="0.28701 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="-0.923874 0.382696 0 -2.77163" album="" material="bm_grid_blank4" texgens="-0.382687 -0.923878 0 128.014 0 0 -1 768 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="-0.923874 -0.382697 0 -2.77162" album="" material="bm_grid_blank4" texgens="0.382682 -0.92388 0 127.979 0 0 -1 768 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="-0.382711 -0.923868 0 -2.7716" album="" material="bm_grid_blank4" texgens="0.92388 -0.382683 0 128.003 0 0 -1 768 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="0.382704 -0.923871 0 -2.77162" album="" material="bm_grid_blank4" texgens="0.923878 0.382686 0 127.998 0 0 -1 768 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="0.923879 -0.382685 0 -2.77164" album="" material="bm_grid_blank4" texgens="0.382681 0.92388 0 128.025 0 0 -1 768 0 0.287011 0.25" texRot="0" texScale="0.287011 0.25" texDiv="256 256">
                            <Indices indices=" 15 3 2 14" />
                        </Face>
                        <Face id="8" plane="-0 0 -1 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 14 2 0 4 6 8 10 12" />
                        </Face>
                        <Face id="9" plane="0 -0 1 -6" album="" material="bm_friction_grass" texgens="1 0 0 -14080 0 -1 0 10752 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="330" owner="0" type="0" pos="-110 -84 -0.5" rot="1 0 0 0" scale="" transform="1 0 0 -110 0 1 0 -84 0 0 1 -0.5 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="33">
                        <Vertices>
                            <Vertex pos="0.692907 0.286877 -11" />
                            <Vertex pos="0.692909 0.28688 39" />
                            <Vertex pos="0.75 0 -11" />
                            <Vertex pos="0.75 0 39" />
                            <Vertex pos="0.530345 0.530308 -11" />
                            <Vertex pos="0.53035 0.530304 39" />
                            <Vertex pos="0.286971 0.69281 -11" />
                            <Vertex pos="0.286972 0.69281 39" />
                            <Vertex pos="2.47955e-005 0.75 -11" />
                            <Vertex pos="2.28882e-005 0.75 39" />
                            <Vertex pos="-0.287071 0.692814 -11" />
                            <Vertex pos="-0.287071 0.69281 39" />
                            <Vertex pos="-0.530313 0.530315 -11" />
                            <Vertex pos="-0.530312 0.530319 39" />
                            <Vertex pos="-0.692904 0.286884 -11" />
                            <Vertex pos="-0.692902 0.28688 39" />
                            <Vertex pos="-0.75 0 -11" />
                            <Vertex pos="-0.75 0 39" />
                            <Vertex pos="-0.692907 -0.286873 -11" />
                            <Vertex pos="-0.692909 -0.286873 39" />
                            <Vertex pos="-0.530376 -0.530308 -11" />
                            <Vertex pos="-0.53038 -0.530304 39" />
                            <Vertex pos="-0.286956 -0.692818 -11" />
                            <Vertex pos="-0.286957 -0.692818 39" />
                            <Vertex pos="1.00136e-005 -0.750004 -11" />
                            <Vertex pos="7.62939e-006 -0.75 39" />
                            <Vertex pos="0.286997 -0.692822 -11" />
                            <Vertex pos="0.286995 -0.692825 39" />
                            <Vertex pos="0.53034 -0.530319 -11" />
                            <Vertex pos="0.530342 -0.530319 39" />
                            <Vertex pos="0.692906 -0.28688 -11" />
                            <Vertex pos="0.692902 -0.28688 39" />
                        </Vertices>
                        <Face id="0" plane="0.980768 0.195179 -5.13852e-008 -0.735574" album="" material="solid_bm" texgens="-0.195089 0.980786 0 4.6792 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.831617 0.55535 -3.89187e-008 -0.735551" album="" material="solid_bm" texgens="-0.555572 0.831468 0 14.0393 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0.555298 0.831652 -1.09224e-008 -0.735531" album="" material="solid_bm" texgens="-0.831471 0.555569 0 23.4103 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="0.195461 0.980711 7.45607e-009 -0.735538" album="" material="solid_bm" texgens="-0.980786 0.195088 0 32.7745 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="-0.19535 0.980734 7.83314e-008 -0.735545" album="" material="solid_bm" texgens="-0.980784 -0.195095 0 42.1397 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="-0.555499 0.831517 -5.5156e-008 -0.735555" album="" material="solid_bm" texgens="-0.831471 -0.555568 0 51.5062 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="-0.831571 0.555418 7.74057e-008 -0.735539" album="" material="solid_bm" texgens="-0.555573 -0.831468 0 60.8636 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="-0.980765 0.195193 0 -0.735574" album="" material="solid_bm" texgens="-0.195092 -0.980785 0 70.2384 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 17 16 14 15" />
                        </Face>
                        <Face id="8" plane="-0.980765 -0.19519 -3.97516e-008 -0.735574" album="" material="solid_bm" texgens="0.195089 -0.980786 0 79.6007 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 19 18 16 17" />
                        </Face>
                        <Face id="9" plane="-0.83167 -0.55527 -2.20761e-008 -0.735562" album="" material="solid_bm" texgens="0.555567 -0.831472 0 88.9565 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 21 20 18 19" />
                        </Face>
                        <Face id="10" plane="-0.555244 -0.831687 -1.09214e-008 -0.735539" album="" material="solid_bm" texgens="0.831471 -0.555569 0 98.3286 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 23 22 20 21" />
                        </Face>
                        <Face id="11" plane="-0.195435 -0.980717 6.90109e-008 -0.735539" album="" material="solid_bm" texgens="0.980786 -0.195089 0 107.69 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 25 24 22 23" />
                        </Face>
                        <Face id="12" plane="0.195408 -0.980722 -5.1821e-008 -0.735548" album="" material="solid_bm" texgens="0.980785 0.195092 0 117.055 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 27 26 24 25" />
                        </Face>
                        <Face id="13" plane="0.555349 -0.831617 -2.18469e-008 -0.735547" album="" material="solid_bm" texgens="0.831468 0.555572 0 126.421 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 29 28 26 27" />
                        </Face>
                        <Face id="14" plane="0.831619 -0.555346 6.64216e-008 -0.735551" album="" material="solid_bm" texgens="0.555569 0.83147 0 135.786 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 30 28 29" />
                        </Face>
                        <Face id="15" plane="0.980763 -0.195202 0 -0.735572" album="" material="solid_bm" texgens="0.195087 0.980786 0 145.144 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 3 2 30" />
                        </Face>
                        <Face id="16" plane="-0 0 -1 -11" album="" material="solid_bm" texgens="-1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 30 2 0 4 6 8 10 12 14 16 18 20 22 24 26 28" />
                        </Face>
                        <Face id="17" plane="0 -0 1 -39" album="" material="solid_bm" texgens="1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 29 27 25 23 21 19 17 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="331" owner="0" type="0" pos="-106 -22 0.5" rot="1 0 0 0" scale="" transform="1 0 0 -106 0 1 0 -22 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="17">
                        <Vertices>
                            <Vertex pos="2.12132 2.12125 -6" />
                            <Vertex pos="2.12132 2.12125 6" />
                            <Vertex pos="3 3.8147e-006 -6" />
                            <Vertex pos="3 3.8147e-006 6" />
                            <Vertex pos="-9.05991e-006 3 -6" />
                            <Vertex pos="-9.05991e-006 3 6" />
                            <Vertex pos="-2.12132 2.12125 -6" />
                            <Vertex pos="-2.12132 2.12125 6" />
                            <Vertex pos="-3 7.62939e-006 -6" />
                            <Vertex pos="-3 7.62939e-006 6" />
                            <Vertex pos="-2.12131 -2.12125 -6" />
                            <Vertex pos="-2.12131 -2.12125 6" />
                            <Vertex pos="4.76837e-006 -3 -6" />
                            <Vertex pos="4.76837e-006 -3 6" />
                            <Vertex pos="2.12134 -2.12126 -6" />
                            <Vertex pos="2.12134 -2.12126 6" />
                        </Vertices>
                        <Face id="0" plane="0.923875 0.382695 0 -2.77163" album="" material="bm_grid_blank4" texgens="-0.382684 0.92388 0 127.988 0 0 -1 768 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.382708 0.923869 -0 -2.7716" album="" material="bm_grid_blank4" texgens="-0.92388 0.382682 0 128.003 0 0 -1 768 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="-0.382711 0.923868 0 -2.77161" album="" material="bm_grid_blank4" texgens="-0.92388 -0.382683 0 128.006 0 0 -1 768 0 0.28701 0.25" texRot="0" texScale="0.28701 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="-0.923874 0.382696 0 -2.77163" album="" material="bm_grid_blank4" texgens="-0.382687 -0.923878 0 128.014 0 0 -1 768 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="-0.923874 -0.382697 0 -2.77162" album="" material="bm_grid_blank4" texgens="0.382682 -0.92388 0 127.979 0 0 -1 768 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="-0.382711 -0.923868 0 -2.7716" album="" material="bm_grid_blank4" texgens="0.92388 -0.382683 0 128.003 0 0 -1 768 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="0.382704 -0.923871 0 -2.77162" album="" material="bm_grid_blank4" texgens="0.923878 0.382686 0 127.998 0 0 -1 768 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="0.923879 -0.382685 0 -2.77164" album="" material="bm_grid_blank4" texgens="0.382681 0.92388 0 128.025 0 0 -1 768 0 0.287011 0.25" texRot="0" texScale="0.287011 0.25" texDiv="256 256">
                            <Indices indices=" 15 3 2 14" />
                        </Face>
                        <Face id="8" plane="-0 0 -1 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 14 2 0 4 6 8 10 12" />
                        </Face>
                        <Face id="9" plane="0 -0 1 -6" album="" material="bm_friction_grass" texgens="1 0 0 -13568 0 -1 0 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="332" owner="0" type="0" pos="-106 -22 -0.5" rot="1 0 0 0" scale="" transform="1 0 0 -106 0 1 0 -22 0 0 1 -0.5 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="33">
                        <Vertices>
                            <Vertex pos="0.692909 0.286877 7" />
                            <Vertex pos="0.692909 0.28688 43" />
                            <Vertex pos="0.75 0 7" />
                            <Vertex pos="0.75 0 43" />
                            <Vertex pos="0.530342 0.530308 7" />
                            <Vertex pos="0.53035 0.530304 43" />
                            <Vertex pos="0.286972 0.69281 7" />
                            <Vertex pos="0.286972 0.69281 43" />
                            <Vertex pos="2.28882e-005 0.75 7" />
                            <Vertex pos="2.28882e-005 0.75 43" />
                            <Vertex pos="-0.287071 0.692814 7" />
                            <Vertex pos="-0.287071 0.69281 43" />
                            <Vertex pos="-0.530312 0.530315 7" />
                            <Vertex pos="-0.530312 0.530319 43" />
                            <Vertex pos="-0.692902 0.286884 7" />
                            <Vertex pos="-0.692902 0.28688 43" />
                            <Vertex pos="-0.75 0 7" />
                            <Vertex pos="-0.75 0 43" />
                            <Vertex pos="-0.692909 -0.286873 7" />
                            <Vertex pos="-0.692909 -0.286873 43" />
                            <Vertex pos="-0.53038 -0.530308 7" />
                            <Vertex pos="-0.53038 -0.530304 43" />
                            <Vertex pos="-0.286957 -0.692818 7" />
                            <Vertex pos="-0.286957 -0.692818 43" />
                            <Vertex pos="7.62939e-006 -0.750004 7" />
                            <Vertex pos="7.62939e-006 -0.75 43" />
                            <Vertex pos="0.286995 -0.692822 7" />
                            <Vertex pos="0.286995 -0.692825 43" />
                            <Vertex pos="0.530342 -0.530319 7" />
                            <Vertex pos="0.530342 -0.530319 43" />
                            <Vertex pos="0.692909 -0.28688 7" />
                            <Vertex pos="0.692902 -0.28688 43" />
                        </Vertices>
                        <Face id="0" plane="0.980768 0.195179 -1.61578e-008 -0.735575" album="" material="solid_bm" texgens="-0.195089 0.980786 0 4.6792 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.831609 0.555362 -1.24272e-007 -0.735549" album="" material="solid_bm" texgens="-0.555572 0.831468 0 14.0393 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0.555304 0.831647 -0 -0.73553" album="" material="solid_bm" texgens="-0.831471 0.555569 0 23.4103 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="0.195459 0.980712 -0 -0.735538" album="" material="solid_bm" texgens="-0.980786 0.195088 0 32.7745 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="-0.195352 0.980733 1.08794e-007 -0.735546" album="" material="solid_bm" texgens="-0.980784 -0.195095 0 42.1397 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="-0.555501 0.831516 -9.22408e-008 -0.735553" album="" material="solid_bm" texgens="-0.831471 -0.555568 0 51.5062 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="-0.831573 0.555416 6.20726e-008 -0.735539" album="" material="solid_bm" texgens="-0.555573 -0.831468 0 60.8636 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="-0.980764 0.195199 0 -0.735573" album="" material="solid_bm" texgens="-0.195092 -0.980785 0 70.2384 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 17 16 14 15" />
                        </Face>
                        <Face id="8" plane="-0.980767 -0.195184 0 -0.735575" album="" material="solid_bm" texgens="0.195089 -0.980786 0 79.6007 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 19 18 16 17" />
                        </Face>
                        <Face id="9" plane="-0.831673 -0.555265 6.15961e-008 -0.735565" album="" material="solid_bm" texgens="0.555567 -0.831472 0 88.9565 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 21 20 18 19" />
                        </Face>
                        <Face id="10" plane="-0.555239 -0.831691 0 -0.73554" album="" material="solid_bm" texgens="0.831471 -0.555569 0 98.3286 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 23 22 20 21" />
                        </Face>
                        <Face id="11" plane="-0.195436 -0.980716 1.08792e-007 -0.735541" album="" material="solid_bm" texgens="0.980786 -0.195089 0 107.69 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 25 24 22 23" />
                        </Face>
                        <Face id="12" plane="0.195408 -0.980722 -8.28121e-008 -0.735546" album="" material="solid_bm" texgens="0.980785 0.195092 0 117.055 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 27 26 24 25" />
                        </Face>
                        <Face id="13" plane="0.555343 -0.831622 0 -0.735546" album="" material="solid_bm" texgens="0.831468 0.555572 0 126.421 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 29 28 26 27" />
                        </Face>
                        <Face id="14" plane="0.831617 -0.555349 1.61097e-007 -0.735555" album="" material="solid_bm" texgens="0.555569 0.83147 0 135.786 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 30 28 29" />
                        </Face>
                        <Face id="15" plane="0.980763 -0.195202 0 -0.735572" album="" material="solid_bm" texgens="0.195087 0.980786 0 145.144 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 3 2 30" />
                        </Face>
                        <Face id="16" plane="-0 0 -1 7" album="" material="solid_bm" texgens="-1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 30 2 0 4 6 8 10 12 14 16 18 20 22 24 26 28" />
                        </Face>
                        <Face id="17" plane="0 -0 1 -43" album="" material="solid_bm" texgens="1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 29 27 25 23 21 19 17 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="333" owner="0" type="0" pos="-98 -4 0.5" rot="1 0 0 0" scale="" transform="1 0 0 -98 0 1 0 -4 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="17">
                        <Vertices>
                            <Vertex pos="2.12132 2.12125 -6" />
                            <Vertex pos="2.12132 2.12125 6" />
                            <Vertex pos="3 3.8147e-006 -6" />
                            <Vertex pos="3 3.8147e-006 6" />
                            <Vertex pos="-9.05991e-006 3 -6" />
                            <Vertex pos="-9.05991e-006 3 6" />
                            <Vertex pos="-2.12132 2.12125 -6" />
                            <Vertex pos="-2.12132 2.12125 6" />
                            <Vertex pos="-3 7.62939e-006 -6" />
                            <Vertex pos="-3 7.62939e-006 6" />
                            <Vertex pos="-2.12131 -2.12125 -6" />
                            <Vertex pos="-2.12131 -2.12125 6" />
                            <Vertex pos="4.76837e-006 -3 -6" />
                            <Vertex pos="4.76837e-006 -3 6" />
                            <Vertex pos="2.12134 -2.12126 -6" />
                            <Vertex pos="2.12134 -2.12126 6" />
                        </Vertices>
                        <Face id="0" plane="0.923875 0.382695 0 -2.77163" album="" material="bm_grid_blank4" texgens="-0.382684 0.92388 0 127.988 0 0 -1 768 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.382708 0.923869 -0 -2.7716" album="" material="bm_grid_blank4" texgens="-0.92388 0.382682 0 128.003 0 0 -1 768 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="-0.382711 0.923868 0 -2.77161" album="" material="bm_grid_blank4" texgens="-0.92388 -0.382683 0 128.006 0 0 -1 768 0 0.28701 0.25" texRot="0" texScale="0.28701 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="-0.923874 0.382696 0 -2.77163" album="" material="bm_grid_blank4" texgens="-0.382687 -0.923878 0 128.014 0 0 -1 768 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="-0.923874 -0.382697 0 -2.77162" album="" material="bm_grid_blank4" texgens="0.382682 -0.92388 0 127.979 0 0 -1 768 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="-0.382711 -0.923868 0 -2.7716" album="" material="bm_grid_blank4" texgens="0.92388 -0.382683 0 128.003 0 0 -1 768 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="0.382704 -0.923871 0 -2.77162" album="" material="bm_grid_blank4" texgens="0.923878 0.382686 0 127.998 0 0 -1 768 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="0.923879 -0.382685 0 -2.77164" album="" material="bm_grid_blank4" texgens="0.382681 0.92388 0 128.025 0 0 -1 768 0 0.287011 0.25" texRot="0" texScale="0.287011 0.25" texDiv="256 256">
                            <Indices indices=" 15 3 2 14" />
                        </Face>
                        <Face id="8" plane="-0 0 -1 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 14 2 0 4 6 8 10 12" />
                        </Face>
                        <Face id="9" plane="0 -0 1 -6" album="" material="bm_friction_grass" texgens="1 0 0 -12544 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="334" owner="0" type="0" pos="-98 -4 -0.5" rot="1 0 0 0" scale="" transform="1 0 0 -98 0 1 0 -4 0 0 1 -0.5 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="33">
                        <Vertices>
                            <Vertex pos="0.692909 0.286877 7" />
                            <Vertex pos="0.692909 0.28688 51" />
                            <Vertex pos="0.75 0 7" />
                            <Vertex pos="0.75 0 51" />
                            <Vertex pos="0.530342 0.530308 7" />
                            <Vertex pos="0.53035 0.530304 51" />
                            <Vertex pos="0.286972 0.69281 7" />
                            <Vertex pos="0.286972 0.69281 51" />
                            <Vertex pos="2.28882e-005 0.75 7" />
                            <Vertex pos="2.28882e-005 0.75 51" />
                            <Vertex pos="-0.287071 0.692814 7" />
                            <Vertex pos="-0.287071 0.69281 51" />
                            <Vertex pos="-0.530312 0.530315 7" />
                            <Vertex pos="-0.530312 0.530319 51" />
                            <Vertex pos="-0.692902 0.286884 7" />
                            <Vertex pos="-0.692902 0.28688 51" />
                            <Vertex pos="-0.75 0 7" />
                            <Vertex pos="-0.75 0 51" />
                            <Vertex pos="-0.692909 -0.286873 7" />
                            <Vertex pos="-0.692909 -0.286873 51" />
                            <Vertex pos="-0.53038 -0.530308 7" />
                            <Vertex pos="-0.53038 -0.530304 51" />
                            <Vertex pos="-0.286957 -0.692818 7" />
                            <Vertex pos="-0.286957 -0.692818 51" />
                            <Vertex pos="7.62939e-006 -0.750004 7" />
                            <Vertex pos="7.62939e-006 -0.75 51" />
                            <Vertex pos="0.286995 -0.692822 7" />
                            <Vertex pos="0.286995 -0.692825 51" />
                            <Vertex pos="0.530342 -0.530319 7" />
                            <Vertex pos="0.530342 -0.530319 51" />
                            <Vertex pos="0.692909 -0.28688 7" />
                            <Vertex pos="0.692902 -0.28688 51" />
                        </Vertices>
                        <Face id="0" plane="0.980768 0.195179 -1.322e-008 -0.735575" album="" material="solid_bm" texgens="-0.195089 0.980786 0 4.6792 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.831609 0.555362 -1.01677e-007 -0.735549" album="" material="solid_bm" texgens="-0.555572 0.831468 0 14.0393 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0.555304 0.831647 -0 -0.73553" album="" material="solid_bm" texgens="-0.831471 0.555569 0 23.4103 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="0.195459 0.980712 -0 -0.735538" album="" material="solid_bm" texgens="-0.980786 0.195088 0 32.7745 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="-0.195352 0.980733 8.90129e-008 -0.735546" album="" material="solid_bm" texgens="-0.980784 -0.195095 0 42.1397 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="-0.555501 0.831516 -7.54697e-008 -0.735554" album="" material="solid_bm" texgens="-0.831471 -0.555568 0 51.5062 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="-0.831573 0.555416 5.07866e-008 -0.735539" album="" material="solid_bm" texgens="-0.555573 -0.831468 0 60.8636 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="-0.980764 0.195199 0 -0.735573" album="" material="solid_bm" texgens="-0.195092 -0.980785 0 70.2384 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 17 16 14 15" />
                        </Face>
                        <Face id="8" plane="-0.980767 -0.195184 0 -0.735575" album="" material="solid_bm" texgens="0.195089 -0.980786 0 79.6007 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 19 18 16 17" />
                        </Face>
                        <Face id="9" plane="-0.831673 -0.555265 5.03968e-008 -0.735565" album="" material="solid_bm" texgens="0.555567 -0.831472 0 88.9565 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 21 20 18 19" />
                        </Face>
                        <Face id="10" plane="-0.555239 -0.831691 0 -0.73554" album="" material="solid_bm" texgens="0.831471 -0.555569 0 98.3286 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 23 22 20 21" />
                        </Face>
                        <Face id="11" plane="-0.195436 -0.980717 8.90114e-008 -0.73554" album="" material="solid_bm" texgens="0.980786 -0.195089 0 107.69 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 25 24 22 23" />
                        </Face>
                        <Face id="12" plane="0.195408 -0.980722 -6.77553e-008 -0.735547" album="" material="solid_bm" texgens="0.980785 0.195092 0 117.055 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 27 26 24 25" />
                        </Face>
                        <Face id="13" plane="0.555343 -0.831622 0 -0.735546" album="" material="solid_bm" texgens="0.831468 0.555572 0 126.421 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 29 28 26 27" />
                        </Face>
                        <Face id="14" plane="0.831617 -0.555349 1.31807e-007 -0.735555" album="" material="solid_bm" texgens="0.555569 0.83147 0 135.786 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 30 28 29" />
                        </Face>
                        <Face id="15" plane="0.980763 -0.195202 0 -0.735572" album="" material="solid_bm" texgens="0.195087 0.980786 0 145.144 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 3 2 30" />
                        </Face>
                        <Face id="16" plane="-0 0 -1 7" album="" material="solid_bm" texgens="-1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 30 2 0 4 6 8 10 12 14 16 18 20 22 24 26 28" />
                        </Face>
                        <Face id="17" plane="0 -0 1 -51" album="" material="solid_bm" texgens="1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 29 27 25 23 21 19 17 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="335" owner="0" type="0" pos="-106 -22 9.5" rot="1 0 0 0" scale="" transform="1 0 0 -106 0 1 0 -22 0 0 1 9.5 0 0 0 1" group="-1" locked="0" nextFaceID="41" nextVertexID="17">
                        <Vertices>
                            <Vertex pos="3.53553 3.53553 -33" />
                            <Vertex pos="3.53553 3.53553 -15" />
                            <Vertex pos="5 3.8147e-006 -33" />
                            <Vertex pos="5 1.90735e-006 -15" />
                            <Vertex pos="-2.00272e-005 5 -33" />
                            <Vertex pos="-2.09808e-005 5 -15" />
                            <Vertex pos="-3.53552 3.53555 -33" />
                            <Vertex pos="-3.53552 3.53555 -15" />
                            <Vertex pos="-5 1.14441e-005 -33" />
                            <Vertex pos="-5 1.23978e-005 -15" />
                            <Vertex pos="-3.53554 -3.53553 -33" />
                            <Vertex pos="-3.53554 -3.53553 -15" />
                            <Vertex pos="5.72205e-006 -5 -33" />
                            <Vertex pos="5.72205e-006 -5 -15" />
                            <Vertex pos="3.53554 -3.53552 -33" />
                            <Vertex pos="3.53554 -3.53552 -15" />
                        </Vertices>
                        <Face id="30" plane="0.923879 0.382685 0 -4.6194" album="Blasted" material="bm_grid_blank4" texgens="-0.382685 0.923879 0 0 0 0 -1 640 0 0.239177 0.25" texRot="0" texScale="0.239177 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="31" plane="0.382683 0.92388 2.02737e-008 -4.61939" album="Blasted" material="bm_grid_blank4" texgens="-0.92388 0.382683 0 -0.00186157 0 0 -1 640 0 0.239177 0.25" texRot="0" texScale="0.239177 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="32" plane="-0.382683 0.92388 0 -4.61941" album="Blasted" material="bm_grid_blank4" texgens="-0.92388 -0.382683 0 0 0 0 -1 640 0 0.239177 0.25" texRot="0" texScale="0.239177 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="33" plane="-0.923878 0.382686 -2.0276e-008 -4.6194" album="Blasted" material="bm_grid_blank4" texgens="-0.382686 -0.923878 0 -0.000106812 0 0 -1 640 0 0.239177 0.25" texRot="0" texScale="0.239177 0.25" texDiv="256 256">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="34" plane="-0.92388 -0.382681 0 -4.6194" album="Blasted" material="bm_grid_blank4" texgens="0.382681 -0.923881 0 0.00012207 0 0 -1 640 0 0.239177 0.25" texRot="0" texScale="0.239177 0.25" texDiv="256 256">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="35" plane="-0.382683 -0.92388 0 -4.6194" album="Blasted" material="bm_grid_blank4" texgens="0.92388 -0.382683 0 0 0 0 -1 640 0 0.239177 0.25" texRot="0" texScale="0.239177 0.25" texDiv="256 256">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="36" plane="0.382686 -0.923878 0 -4.61939" album="Blasted" material="bm_grid_blank4" texgens="0.923878 0.382686 0 -0.000106812 0 0 -1 640 0 0.239177 0.25" texRot="0" texScale="0.239177 0.25" texDiv="256 256">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="37" plane="0.92388 -0.382683 -4.05506e-008 -4.6194" album="Blasted" material="bm_grid_blank4" texgens="0.382683 0.92388 0 0 0 0 -1 640 0 0.239177 0.25" texRot="0" texScale="0.239177 0.25" texDiv="256 256">
                            <Indices indices=" 15 3 2 14" />
                        </Face>
                        <Face id="38" plane="-0 0 -1 -33" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -384 0 -1 0 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 14 2 0 4 6 8 10 12" />
                        </Face>
                        <Face id="39" plane="0 -0 1 15" album="" material="bm_friction_grass" texgens="1 0 0 -13568 0 -1 0 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="336" owner="0" type="0" pos="-98 -4 9.5" rot="1 0 0 0" scale="" transform="1 0 0 -98 0 1 0 -4 0 0 1 9.5 0 0 0 1" group="-1" locked="0" nextFaceID="41" nextVertexID="17">
                        <Vertices>
                            <Vertex pos="3.53553 3.53553 -33" />
                            <Vertex pos="3.53553 3.53553 -15" />
                            <Vertex pos="5 3.8147e-006 -33" />
                            <Vertex pos="5 1.90735e-006 -15" />
                            <Vertex pos="-2.00272e-005 5 -33" />
                            <Vertex pos="-2.09808e-005 5 -15" />
                            <Vertex pos="-3.53552 3.53555 -33" />
                            <Vertex pos="-3.53552 3.53555 -15" />
                            <Vertex pos="-5 1.14441e-005 -33" />
                            <Vertex pos="-5 1.23978e-005 -15" />
                            <Vertex pos="-3.53554 -3.53553 -33" />
                            <Vertex pos="-3.53554 -3.53553 -15" />
                            <Vertex pos="5.72205e-006 -5 -33" />
                            <Vertex pos="5.72205e-006 -5 -15" />
                            <Vertex pos="3.53554 -3.53552 -33" />
                            <Vertex pos="3.53554 -3.53552 -15" />
                        </Vertices>
                        <Face id="30" plane="0.923879 0.382685 0 -4.6194" album="Blasted" material="bm_grid_blank4" texgens="-0.382685 0.923879 0 0 0 0 -1 640 0 0.239177 0.25" texRot="0" texScale="0.239177 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="31" plane="0.382683 0.92388 2.02737e-008 -4.61939" album="Blasted" material="bm_grid_blank4" texgens="-0.92388 0.382683 0 -0.00186157 0 0 -1 640 0 0.239177 0.25" texRot="0" texScale="0.239177 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="32" plane="-0.382683 0.92388 0 -4.61941" album="Blasted" material="bm_grid_blank4" texgens="-0.92388 -0.382683 0 0 0 0 -1 640 0 0.239177 0.25" texRot="0" texScale="0.239177 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="33" plane="-0.923878 0.382686 -2.0276e-008 -4.6194" album="Blasted" material="bm_grid_blank4" texgens="-0.382686 -0.923878 0 -0.000106812 0 0 -1 640 0 0.239177 0.25" texRot="0" texScale="0.239177 0.25" texDiv="256 256">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="34" plane="-0.92388 -0.382681 0 -4.6194" album="Blasted" material="bm_grid_blank4" texgens="0.382681 -0.923881 0 0.00012207 0 0 -1 640 0 0.239177 0.25" texRot="0" texScale="0.239177 0.25" texDiv="256 256">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="35" plane="-0.382683 -0.92388 0 -4.6194" album="Blasted" material="bm_grid_blank4" texgens="0.92388 -0.382683 0 0 0 0 -1 640 0 0.239177 0.25" texRot="0" texScale="0.239177 0.25" texDiv="256 256">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="36" plane="0.382686 -0.923878 0 -4.61939" album="Blasted" material="bm_grid_blank4" texgens="0.923878 0.382686 0 -0.000106812 0 0 -1 640 0 0.239177 0.25" texRot="0" texScale="0.239177 0.25" texDiv="256 256">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="37" plane="0.92388 -0.382683 -4.05506e-008 -4.6194" album="Blasted" material="bm_grid_blank4" texgens="0.382683 0.92388 0 0 0 0 -1 640 0 0.239177 0.25" texRot="0" texScale="0.239177 0.25" texDiv="256 256">
                            <Indices indices=" 15 3 2 14" />
                        </Face>
                        <Face id="38" plane="-0 0 -1 -33" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -384 0 -1 0 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 14 2 0 4 6 8 10 12" />
                        </Face>
                        <Face id="39" plane="0 -0 1 15" album="" material="bm_friction_grass" texgens="1 0 0 -12544 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                </Brushes>
            </InteriorMap>
        </DetailLevel>
    </DetailLevels>
</ConstructorScene>
